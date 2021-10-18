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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
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

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
