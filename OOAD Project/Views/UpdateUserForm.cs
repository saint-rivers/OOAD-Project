using OOAD_Project.Models;
using OOAD_Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project.Views
{
    public partial class UpdateUserForm : PForm
    {
        public bool updatedSuccessfully;

        public UpdateUserForm(MemberService memberService)
        {
            this.memberService = memberService;
            InitializeComponent();
        }

        private void projectUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagementDataSet);
        }


        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.ProjectUsers' table. You can move, or remove it, as needed.
            this.projectUsersTableAdapter.Fill(this.projectManagementDataSet.ProjectUsers);
            userSecretTextBox.Text = "";

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateMatchingPasswords()
        {
            if (userSecretTextBox.Text == "" || secretConfirmationTextBox.Text == "")
            {
                MessageBox.Show("Passwords cannot be empty");
                return false;
            }
            return userSecretTextBox.Text == secretConfirmationTextBox.Text;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateMatchingPasswords())
            {
                updatedSuccessfully = false;
                return;
            }

            int _memberId = int.Parse(idTextBox.Text);
            Credentials credentials = new Credentials(
                _memberId,
                firstnameTextBox.Text,
                lastnameTextBox.Text,  
                emailTextBox.Text,
                userSecretTextBox.Text
                );

            updatedSuccessfully = memberService.UpdateMemberCredentials(_memberId, credentials);
            if (updatedSuccessfully)
            {
                MessageBox.Show("Credentials updated successfully.");
                Close();
            } 
            else
            {
                MessageBox.Show("Unable to update information.");
            }
        }
    }
}
