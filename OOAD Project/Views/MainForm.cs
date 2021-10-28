using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using OOAD_Project.Controllers;
using OOAD_Project.Models;

namespace OOAD_Project
{
    public partial class MainForm : Form
    {
        //Dictionary<int, string> members = new Dictionary<int, string>();
        List<string> memberNames = new List<string>();
        List<Project> projects = new List<Project>();
        Member currentUser;
        Dictionary<string, int> projectNameId;

        private ProjectController projectController;
        private MemberController memberController;

        public MainForm()
        {
            InitializeComponent();
            projectController = new ProjectController();
            memberController = new MemberController();
        }

        private static Dictionary<string, int> MapifyProject(List<Project> projects)
        {
            Dictionary<string, int> projectNameId = new Dictionary<string, int>();
            foreach (Project project in projects)
            {
                projectNameId.Add(project.title, project.id);
            }
            return projectNameId;
        }

        private void RunLoginDialog()
        {
            LoginForm loginForm = new LoginForm(projectController, memberController);
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
                    int defaultSelectedProject = projects[0].id;
                    string[] tmp = GetProjectMembers(defaultSelectedProject);
                    firstnameListBox.Items.AddRange(tmp);

                    LoadProjectsToForm(loginForm.projects);
                    ChangeActiveProject();
                }
            }
        }

        private void LoadProjectsToForm(List<Project> projects)
        {
            string[] userProjects = MapProjectListToStringArray(projects);
            projectTitleComboBox.Items.AddRange(userProjects);
            projectTitleComboBox.SelectedIndex = 0;
            projectNameId = MapifyProject(projects);
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

        private string[] MapProjectListToStringArray(List<Project> projects)
        {
            List<string> results = new List<string>();
            foreach (Project project in projects)
            {
                results.Add(project.title);
            }
            return results.ToArray();
        }

        private void ClearMainForm()
        {
            welcomeLabel.Text = "";
            firstnameListBox.Items.Clear();
            memberNames.Clear();
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm(projectIdTextBox.Text);            
            form.ShowDialog(); 
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm(currentUser.id, projectController, memberController);
            int _projectId = form.projectId;

            if (_projectId != -1)
            {
                // get list of projects 
                int _memberId = memberController.GetValidatedUser().id;
                List<Project> _projects = projectController.GetProjectsOfUser(_memberId);
                LoadProjectsToForm(_projects);
            }
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tasksTableAdapter.Fill(projectManagementDataSet.Tasks);          
            RunLoginDialog();
        }

        private string[] GetProjectMembers(int projectId)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT * FROM [dbo].[view_members_in_group](@project_id)";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                { 
                    conn.Open();
                    comm.Parameters.AddWithValue("@project_id", projectId);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                //members.Add(id, name);
                                name = "#"+id + " " +name;
                                memberNames.Add(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return memberNames.ToArray();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();
        }

        private void viewMemberBtn_Click(object sender, EventArgs e)
        {
            if (firstnameListBox.SelectedIndex != -1)
            {
                string selectedData = firstnameListBox.SelectedItem.ToString();
                string id = selectedData.Substring(selectedData.LastIndexOf('#') + 1);
                id = id.Substring(0, id.IndexOf(' ', id.IndexOf(' ')) + 1);
                ViewUserDetailsForm form = new ViewUserDetailsForm(int.Parse(id));
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
    }
}
