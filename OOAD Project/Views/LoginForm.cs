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
using OOAD_Project.Repositories;
using OOAD_Project.Models;
using OOAD_Project.Services;
using OOAD_Project.Views;

namespace OOAD_Project
{
    public partial class LoginForm : PForm
    {
        public bool isValidLogin = false;
        public List<Project> projects = new List<Project>();
        public Member currentUser;

        public LoginForm(ProjectService projectService, MemberService memberService)
        {
            InitializeComponent();
            FormClosing += LoginForm_Closing;

            this.projectService = projectService;
            this.memberService = memberService;
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

        public Member GetLoggedInUser()
        {
            return currentUser;
        }

        private void initLogin()
        {
            isValidLogin = memberService.ValidateLogin(emailLoginTextBox.Text, passwordTextBox.Text);
            if (isValidLogin)
            {
                DialogResult = DialogResult.OK;
                projects = projectService.GetProjectsOfUser(memberService.GetCurrentUserId());
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
            currentUser = memberService.GetCurrentUser();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
