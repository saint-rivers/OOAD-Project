using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();     
            
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm();            
            form.ShowDialog(); // Shows Form2
        }

        private void newProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm();
            form.ShowDialog();
        }


        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);

        }

        private void projectsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.projectManagementDataSet.Projects);

        }
    }
}
