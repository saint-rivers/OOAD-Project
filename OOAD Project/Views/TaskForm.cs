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
        private int projectId;
        private Member[] members;
        MemberMap memberMap;


        public TaskForm(string projectId, TaskService taskService, MemberService memberService)
        {
            InitializeComponent();
            this.projectId = int.Parse(projectId);
            this.taskService = taskService;
            this.memberService = new MemberService();
            memberMap = new MemberMap();
        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tasksBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(projectManagementDataSet);

        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {

            // get all members
            members = memberService.GetMembersInProjectAsArray(projectId);
            memberMap.AddMemberRange(members);

            // add members to combo box
            string[] names = memberMap.GetMembersAsNameArray();
            if (names.Length == 0)
            {
                Console.WriteLine("No members found");
                return;
            }
            assignedToComboBox.Items.AddRange(names);
            assignedToComboBox.SelectedIndex = 0;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            // get member id for assignedTo
            if (memberMap.IsEmpty())
            {
                Console.WriteLine("No members found");                
                return;
            }
            string selectedName = assignedToComboBox.SelectedItem.ToString();
            int _assignedTo = memberMap.GetIdByName(selectedName);

            ProjectTask task = new ProjectTask(
                projectId, titleTextBox.Text, descriptionRichTextBox.Text, _assignedTo, deadlineDateTimePicker.Value
                );

            taskService.InsertNewTask(projectId, task);
            MessageBox.Show("Added new task.");
            Close();
        }

        private void TaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
