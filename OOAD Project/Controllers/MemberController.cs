using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Controllers
{
    public class MemberController : BaseController
    {
        public Member currentUser = new Member();

        public Member GetValidatedUser()
        {
            if (currentUser != null) return currentUser;
            throw new NullReferenceException("Unable to fetch user.");
        }

        public void InsertProjectMember(int ownerId, int projectId)
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
                    comm.Parameters.AddWithValue("@user_id", ownerId);
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


        public bool ValidateLogin(string email, string secret)
        {
            email = "joy@gmail.com";
            secret = "asd";
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
