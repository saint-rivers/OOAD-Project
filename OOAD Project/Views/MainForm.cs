using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using OOAD_Project.Models;
using OOAD_Project.Services;

namespace OOAD_Project
{
    public partial class MainForm : Form
    {
        //Dictionary<int, string> members = new Dictionary<int, string>();
        List<string> memberNames = new List<string>();
        List<Project> projects = new List<Project>();
        Member currentUser;
        Dictionary<string, int> projectNameId;
        int selectedProject = -1;

        MemberMap memberMap;

        private ProjectService projectService;
        private MemberService memberService;
        private TaskService taskService;

        public MainForm()
        {
            InitializeComponent();
            projectService = new ProjectService();
            memberService = new MemberService();
            taskService = new TaskService();
        }

        private void RunLoginDialog()
        {
            LoginForm loginForm = new LoginForm(projectService, memberService);
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                ClearMainForm();

                // say hello
                welcomeLabel.Text = "Hello, " + loginForm.currentUser.firstname;

                // get data from login form
                currentUser = loginForm.currentUser;
                projects = loginForm.projects;

                projectTitleComboBox.Items.Clear();

                if (projects.Count > 0) {
                    selectedProject = projects[0].id;
                    Member[] _members = memberService.GetMembersInProjectAsArray(selectedProject);
                    memberMap = new MemberMap(_members);
                    membersListBox.Items.AddRange(memberMap.GetMembersAsNameArray());

                    LoadProjectsToForm(loginForm.projects);
                    ChangeActiveProject();
                }
            }
        }

        private void LoadProjectsToForm(List<Project> projects)
        {
            projectTitleComboBox.Items.Clear();

            string[] userProjects = projectService.MapProjectListToStringArray(projects);
            projectTitleComboBox.Items.AddRange(userProjects);
            projectTitleComboBox.SelectedIndex = 0;
            projectNameId = projectService.MapifyProject(projects);
        }

        private void ChangeActiveProject()
        {
            if (projectTitleComboBox.SelectedIndex == -1 || projectNameId == null)
            {
                return;
            }
            int _projectId = projectNameId[projectTitleComboBox.SelectedItem.ToString()];
            projectIdTextBox.Text = _projectId.ToString();
        }


        private void ClearMainForm()
        {
            welcomeLabel.Text = "";
            membersListBox.Items.Clear();
            memberNames.Clear();
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm(projectIdTextBox.Text, taskService, memberService);
            form.ShowDialog();
            LoadTaskTable(); 

        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm(currentUser.id, projectService, memberService);
            form.ShowDialog();
            int _projectId = form.projectId;

            if (_projectId != -1)
            {
                // get list of projects 
                int _memberId = memberService.GetValidatedUser().id;
                List<Project> _projects = projectService.GetProjectsOfUser(_memberId);
                LoadProjectsToForm(_projects);
            }
        }

        private void LoadTaskTable()
        {
            tasksTableAdapter.Fill(projectManagementDataSet.Tasks);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTaskTable();        
            RunLoginDialog();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm(selectedProject, memberService);
            addMemberForm.ShowDialog();
            ReloadMembers();
        }

        public void ReloadMembers()
        {
            Member[] _members = memberService.GetMembersAsArray(selectedProject);
            memberMap.SetMembers(_members);
            membersListBox.Items.Clear();
            membersListBox.Items.AddRange(memberMap.GetMembersAsNameArray());
        }

        private void viewMemberBtn_Click(object sender, EventArgs e)
        {
            if (membersListBox.SelectedIndex != -1)
            {
                string selectedName = membersListBox.SelectedItem.ToString();
                int id = memberMap.GetIdByName(selectedName);
                ViewUserDetailsForm form = new ViewUserDetailsForm(id);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a member to view.");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            RunLoginDialog();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void projectTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeActiveProject();
        }

        private void removeMember_Click(object sender, EventArgs e)
        {
            if (membersListBox.SelectedIndex != -1)
            {
                string selectedName = membersListBox.SelectedItem.ToString();
                int memberId = memberMap.GetIdByName(selectedName);

                memberService.RemoveMemberFromProject(selectedProject, memberId, selectedName);
                ReloadMembers();
            }
            else
            {
                MessageBox.Show("Please select a member to remove.");
            }
        }
    }
}
