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
using OOAD_Project.Services;
using OOAD_Project.Views;

namespace OOAD_Project
{
    public partial class ProjectForm : PForm
    {
        public int ownerId = -1;
        public int projectId = -1;

        public ProjectForm(int ownerId, ProjectService projectService, MemberService memberService)
        {
            InitializeComponent();
            this.ownerId = ownerId;

            this.projectService = projectService;
            this.memberService = memberService;
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

            Project member = new Project(
                titleTextBox.Text,
                descriptionRichTextBox.Text,
                ownerId,
                DateTime.Now.Date
            );

            projectId = projectService.CreateProjectAndAddUsersToProject(member, ownerId );
            MessageBox.Show("Project created.");
            Close();
        }

        

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
