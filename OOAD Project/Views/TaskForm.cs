using OOAD_Project.Models;
using OOAD_Project.Services;
using OOAD_Project.Views;
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
    public partial class TaskForm : PForm
    {
        int projectId;

        private TaskService taskService;

        public TaskForm(string projectId, TaskService taskService)
        {
            InitializeComponent();
            this.projectId = int.Parse(projectId);
            this.taskService = taskService;

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
            // get member id for assignedTo

            int _assignedTo = 3;

            ProjectTask task = new ProjectTask(
                projectId, titleTextBox.Text, descriptionRichTextBox.Text, _assignedTo, deadlineDateTimePicker.Value
                );

            taskService.InsertNewTask(task);
            MessageBox.Show("Added new task.");
            Close();
        }

        private void TaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
