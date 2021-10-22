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
        int ownerId = -1;

        public ProjectForm(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.projectManagementDataSet.Projects);

        }

        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);

        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            if (ownerId == -1) return;

            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _projectInsert = "INSERT INTO Projects (OwnerId,Title,Description,DateCreated) " +
                                    "OUTPUT Inserted.Id " + 
                                    "VALUES (@owner_id,@title,@description,@date_created)";
            string _memberInsert = "INSERT INTO ProjectMembers (UserId,ProjectId) " +
                                    "VALUES (@user_id, @project_id)";


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
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {                       
                        Console.WriteLine(ex);
                    }
                }

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _memberInsert;
                    comm.Parameters.AddWithValue("@user_id", ownerId);
                    comm.Parameters.AddWithValue("@project_id", titleTextBox.Text);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
