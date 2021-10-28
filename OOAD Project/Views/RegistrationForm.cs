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

            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = "INSERT INTO ProjectUsers (Firstname,Lastname,Email,UserSecret) values (@first,@last,@email,@secret)";
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _query;
                    comm.Parameters.AddWithValue("@first", firstnameTextBox.Text);
                    comm.Parameters.AddWithValue("@last", lastnameTextBox.Text);
                    comm.Parameters.AddWithValue("@email", emailTextBox.Text);
                    comm.Parameters.AddWithValue("@secret", userSecretTextBox.Text);
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
            MessageBox.Show("Registration Completed.");
            Close();
        }
    }
}
