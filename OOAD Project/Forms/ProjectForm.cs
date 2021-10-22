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
    public partial class ProjectForm : Form
    {
        private int ownerId = -1;
        private int projectId = -1;

        public ProjectForm(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.Projects' table. You can move, or remove it, as needed.
            projectsTableAdapter.Fill(projectManagementDataSet.Projects);

        }

        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            projectsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(projectManagementDataSet);

        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            if (ownerId == -1) return;
            projectId = InsertProject();
            InsertProjectMember();

            MessageBox.Show("Project created.");
            Close();
        }

        private int InsertProject()
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _projectInsert = "INSERT INTO Projects (OwnerId,Title,Description,DateCreated) " +
                                    "OUTPUT Inserted.Id " +
                                    "VALUES (@owner_id,@title,@description,@date_created)";
            int _projectId = -1;

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _projectInsert;
                    comm.Parameters.AddWithValue("@owner_id", ownerId);
                    comm.Parameters.AddWithValue("@title", titleTextBox.Text);
                    comm.Parameters.AddWithValue("@description", descriptionRichTextBox.Text);
                    comm.Parameters.AddWithValue("@date_created", DateTime.Now.Date);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _projectId = reader.GetInt32(0);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            return _projectId;
        }

        private void InsertProjectMember()
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _memberInsert = "INSERT INTO ProjectMembers (UserId,ProjectId) " +
                                    "VALUES (@user_id, @project_id)";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                //if (projectId != -1)
                //{
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandType = CommandType.Text;
                        comm.CommandText = _memberInsert;
                        comm.Parameters.AddWithValue("@user_id", ownerId);
                        comm.Parameters.AddWithValue("@project_id", projectId);
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                //}
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
