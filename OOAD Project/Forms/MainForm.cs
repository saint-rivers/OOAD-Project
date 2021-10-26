using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using OOAD_Project.Models;

namespace OOAD_Project
{
    public partial class MainForm : Form
    {
        //Dictionary<int, string> members = new Dictionary<int, string>();
        List<string> memberNames = new List<string>();
        List<Project> projects = new List<Project>();
        ProjectUser currentUser;
        Dictionary<string, int> projectNameId;

        public MainForm()
        {
            InitializeComponent();            
        }

        private static Dictionary<string, int> MapifyProject(List<Project> projects)
        {
            Dictionary<string, int> projectNameId = new Dictionary<string, int>();
            foreach (Project project in projects)
            {
                projectNameId.Add(project.Title, project.Id);
            }
            return projectNameId;
        }

        private void RunLoginDialog()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                ClearMainForm();

                // say hello
                welcomeLabel.Text = "Hello, " + loginForm.projectUser.firstname;

                // get data from login form
                currentUser = loginForm.projectUser;
                projects = loginForm.projects;

                if (projects.Count > 0) {
                    int defaultSelectedProject = projects[0].Id;
                    string[] tmp = GetProjectMembers(defaultSelectedProject);
                    firstnameListBox.Items.AddRange(tmp);

                    string[] userProjects = MapProjectListToStringArray(loginForm.projects);
                    projectTitleComboBox.Items.AddRange(userProjects);
                    projectTitleComboBox.SelectedIndex = 0;
                    projectNameId = MapifyProject(projects);

                    ChangeActiveProject();
                }
            }
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
                results.Add(project.Title);
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
            ProjectForm form = new ProjectForm(currentUser.id);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.ProjectUsers' table. You can move, or remove it, as needed.
            //this.projectUsersTableAdapter.Fill(this.projectManagementDataSet.ProjectUsers);
            // TODO: This line of code loads data into the 'projectManagementDataSet.Projects' table. You can move, or remove it, as needed.
            //this.projectsTableAdapter.Fill(this.projectManagementDataSet.Projects);

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
