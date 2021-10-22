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
    public partial class AddMemberForm : Form
    {
        List<string> memberNames = new List<string>();

        public AddMemberForm()
        {
            InitializeComponent();
            nonMembersListBox.Items.AddRange(getNonProjectMembers(3));
        }

        private string[] getNonProjectMembers(int projectId)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT * FROM [dbo].[view_users_not_in_group](@project_id)";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@project_id", projectId);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                //members.Add(id, name);
                                name = "#" + id + " " + name;
                                memberNames.Add(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return memberNames.ToArray();
        }
    }
}
