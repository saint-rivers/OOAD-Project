using OOAD_Project.Services;
using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool containsMatchingPasswords()
        {
            return userSecretTextBox.Text == secretConfirmationTextBox.Text;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!containsMatchingPasswords())
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            new MemberService().RegisterNewMember(
                new Models.Credentials(firstnameTextBox.Text, lastnameTextBox.Text, emailTextBox.Text, userSecretTextBox.Text)
            );

            MessageBox.Show("Registration Completed.");
            Close();
        }
    }
}
