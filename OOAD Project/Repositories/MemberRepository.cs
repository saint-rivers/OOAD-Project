using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project.Repositories
{
    public class MemberRepository : BaseRepository
    {
        public Member currentUser = new Member();

        public Member GetValidatedUser()
        {
            if (currentUser != null) return currentUser;
            throw new NullReferenceException("Unable to fetch user.");
        }

        //

        public bool UpdateMemberCredentials(int memberId, Credentials newInfo)
        {
            string _connStr = GetConnectionString();
            string _memberInsert = $"UPDATE ProjectUsers " +
                $"SET Firstname = @firstname, Lastname = @lastname, Email = @email, UserSecret = @secret " +
                $"WHERE Id=@memberId;";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _memberInsert;
                    comm.Parameters.AddWithValue("@firstname", newInfo.firstname);
                    comm.Parameters.AddWithValue("@lastname", newInfo.lastname);
                    comm.Parameters.AddWithValue("@email", newInfo.email);
                    comm.Parameters.AddWithValue("@secret", newInfo.secret);
                    comm.Parameters.AddWithValue("@memberId", memberId);
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                        return false;
                    }
                }

            }
            return true;
        }


        public bool InsertProjectMember(int projectId, int memberId)
        {
            string _connStr = GetConnectionString();
            string _memberInsert = "INSERT INTO ProjectMembers (UserId,ProjectId) " +
                                    "VALUES (@user_id, @project_id)";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _memberInsert;
                    comm.Parameters.AddWithValue("@user_id", memberId);
                    comm.Parameters.AddWithValue("@project_id", projectId);
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                        return false;
                    }
                }

            }
            return true;
        }

        // not tested !!!
        public void InsertProjectMembers(int[] members, int projectId)
        {
            string _connStr = GetConnectionString();
            string _memberInsert = "INSERT INTO ProjectMembers (UserId,ProjectId) " +
                                    "VALUES (@user_id, @project_id)";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand())
                {
                    foreach (int memberId in members)
                    {
                        comm.Connection = conn;
                        comm.CommandType = CommandType.Text;
                        comm.CommandText = _memberInsert;
                        comm.Parameters.AddWithValue("@user_id", memberId);
                        comm.Parameters.AddWithValue("@project_id", projectId);
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }

            }
        }

        public void DeleteUserFromProjectMembers(int projectId, int memberId)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"DELETE FROM ProjectMembers WHERE UserId=@user_id AND ProjectId=@project_id";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@user_id", memberId);
                    comm.Parameters.AddWithValue("@project_id", projectId);
                    comm.ExecuteNonQuery();
                }
            }
        }

        public string[] GetMembersInProjectAsStringArray(int projectId)
        {
            List<string> _memberNames = new List<string>();

            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT * FROM [dbo].[view_members_in_group](@project_id)";

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
                                _memberNames.Add(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return _memberNames.ToArray();
        }   
        
        public Member[] GetMembersInProjectAsArray(int projectId)
        {
            List<Member> _memberList = new List<Member>();  
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT Id,Firstname,Lastname,Email FROM [dbo].[view_members_in_group](@project_id)";

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
                                Member member = new Member();
                                member.id = reader.GetInt32(0);
                                member.firstname = reader.GetString(1);
                                member.lastname = reader.GetString(2);
                                member.email = reader.GetString(3);

                                _memberList.Add(member);                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return _memberList.ToArray();
        }

        public Member[] GetMembersNotInProjectAsArray(int projectId)
        {
            List<Member> _memberList = new List<Member>();
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = @"SELECT DISTINCT(Id),Firstname,Lastname,Email FROM [dbo].[view_users_not_in_group](@project_id)";

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
                                Member member = new Member();
                                member.id = reader.GetInt32(0);
                                member.firstname = reader.GetString(1);
                                member.lastname = reader.GetString(2);
                                member.email = reader.GetString(3);

                                _memberList.Add(member);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return _memberList.ToArray();
        }

        public bool ValidateLogin(string email, string secret)
        {           
            string _connStr = GetConnectionString();
            string _query = @"SELECT Count(Id) as count, firstname, lastname, Id
                            FROM ProjectUsers 
                            WHERE Email = @email 
                                AND UserSecret = @secret 
                            GROUP BY Id, firstname, lastname";

            int rows = -1;

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@email", email);
                    comm.Parameters.AddWithValue("@secret", secret);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                rows = reader.GetInt32(0);
                                currentUser.firstname = reader.GetString(1);
                                currentUser.lastname = reader.GetString(2);
                                currentUser.id = reader.GetInt32(3);
                            }
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                        }
                    }
                }
            }
            if (rows == 1) return true;
            return false;
        }
    }
}
