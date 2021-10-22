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

namespace OOAD_Project
{
    public partial class TaskForm : Form
    {
        int projectId;

        public TaskForm(string projectId)
        {
            InitializeComponent();
            this.projectId = int.Parse(projectId);
        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tasksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);

        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.projectManagementDataSet.Tasks);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = "INSERT INTO Tasks (ProjectId, AssignedTo, Title, Description, Deadline) " +
                "values (@pid, @assignedto, @title, @description, @deadline)";
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _query;
                    comm.Parameters.AddWithValue("@pid", projectId);
                    comm.Parameters.AddWithValue("@assignedto", assignedToComboBox.Text);
                    comm.Parameters.AddWithValue("@title", titleTextBox.Text);
                    comm.Parameters.AddWithValue("@description", descriptionRichTextBox.Text);
                    comm.Parameters.AddWithValue("@deadline", deadlineDateTimePicker.Value);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // other codes here
                        // do something with the exception
                        // don't swallow it.
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
