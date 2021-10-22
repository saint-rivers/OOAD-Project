using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_Project.Models;

namespace OOAD_Project
{
    public partial class LoginForm : Form
    {
        bool isValidLogin = false;
        public List<Project> projects = new List<Project>();
        public ProjectUser projectUser = new ProjectUser();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            initLogin();
        }

        private void initLogin()
        {
            isValidLogin = validateLogin(emailLoginTextBox.Text, passwordTextBox.Text);
            if (isValidLogin)
            {
                DialogResult = DialogResult.OK;
                projects = getProjectsOfUser(projectUser.id);
                Close();
            }
            else
            {
                MessageBox.Show("Login attempt failed.");
            }
        }

        private List<Project> getProjectsOfUser(int user_id)
        {
            List<Project> _projects = new List<Project>();

            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT p.Id, p.OwnerId, p.Title, p.Description, p.DateCreated
                            FROM ProjectMembers m inner join Projects p on p.Id = m.ProjectId where UserId=@user_id";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Project _project = new Project();

                                _project.Id = reader.GetInt32(0);
                                _project.OwnerId = reader.GetInt32(1);
                                _project.Title = reader.GetString(2);
                                _project.Description = reader.IsDBNull(3) ? "": reader.GetString(3);
                                _project.DateCreated = reader.GetDateTime(4);

                                _projects.Add(_project);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return _projects;
        }

        private bool validateLogin(string email, string secret)
        {
            email = "joy@gmail.com";
            secret = "asd";
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT Count(Id) as count, firstname, lastname, Id
                            FROM ProjectUsers 
                            WHERE Email = @email 
                                AND UserSecret = @secret 
                            GROUP BY Id, firstname, lastname";

            int rows = -1;

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@email", email);
                    comm.Parameters.AddWithValue("@secret", secret);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                rows = reader.GetInt32(0);
                                projectUser.firstname = reader.GetString(1);
                                projectUser.lastname = reader.GetString(2);
                                projectUser.id = reader.GetInt32(3);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            if (rows == 1) return true;
            return false;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                initLogin();
            }
        }

        private void emailLoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                initLogin();
            }
        }
    }
}
