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
using OOAD_Project.Controllers;
using OOAD_Project.Models;

namespace OOAD_Project
{
    public partial class LoginForm : Form
    {
        bool isValidLogin = false;
        public List<Project> projects = new List<Project>();
        public Member currentUser;

        private ProjectController projectController;
        private MemberController memberController;

        public LoginForm(ProjectController projectController, MemberController memberController)
        {
            InitializeComponent();
            FormClosing += LoginForm_Closing;

            this.projectController = projectController;
            this.memberController = memberController;
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
            isValidLogin = memberController.ValidateLogin(emailLoginTextBox.Text, passwordTextBox.Text);
            if (isValidLogin)
            {
                DialogResult = DialogResult.OK;
                projects = projectController.GetProjectsOfUser(memberController.currentUser.id);
                Close();
            }
            else
            {
                MessageBox.Show("Login attempt failed.");
            }
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

        private void LoginForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            currentUser = memberController.currentUser;
        }
    }
}
