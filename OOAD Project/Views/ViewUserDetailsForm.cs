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

namespace OOAD_Project
{
    public partial class ViewUserDetailsForm : Form
    {
        public ViewUserDetailsForm(int userId)
        {
            InitializeComponent();
            Member user = GetUser(userId);
            idTextBox.Text = user.id.ToString();
            firstnameTextBox.Text = user.firstname;
            lastnameTextBox.Text = user.lastname;
            emailTextBox.Text = user.email;
        }

        private void ViewUserDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementDataSet.ProjectUsers' table. You can move, or remove it, as needed.
            this.projectUsersTableAdapter.Fill(this.projectManagementDataSet.ProjectUsers);

        }

        private Member GetUser(int id)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT * FROM ProjectUsers WHERE id = @id";

            Member user = new Member();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@id", id);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string firstname = reader.GetString(1);
                                string lastname = reader.GetString(2);
                                string email = reader.GetString(3);

                                user = new Member(userId, firstname, lastname, email);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return user;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
