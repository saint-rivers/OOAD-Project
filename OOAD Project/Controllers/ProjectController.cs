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
    public class ProjectController : BaseController
    {

        public List<Project> GetProjectsOfUser(int user_id)
        {
            List<Project> _projects = new List<Project>();

            string _connStr = GetConnectionString();
            string _query = @"SELECT p.Id, p.OwnerId, p.Title, p.Description, p.DateCreated
                            FROM ProjectMembers m inner join Projects p on p.Id = m.ProjectId where UserId=@user_id";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@user_id", user_id);
                    int result = comm.ExecuteNonQuery();

                    // result gives the -1 output.. but on insert its 1
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Project _project = new Project();

                                _project.id = reader.GetInt32(0);
                                _project.ownerId = reader.GetInt32(1);
                                _project.title = reader.GetString(2);
                                _project.description = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                _project.dateCreated = reader.GetDateTime(4);

                                _projects.Add(_project);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return _projects;
        }

        public int InsertProject(Project project)
        {
            string _connStr = GetConnectionString();
            string _projectInsert = "INSERT INTO Projects (OwnerId,Title,Description,DateCreated) " +
                                    "OUTPUT Inserted.Id " +
                                    "VALUES (@owner_id,@title,@description,@date_created)";
            int _projectId = -1;

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _projectInsert;
                    comm.Parameters.AddWithValue("@owner_id", project.id);
                    comm.Parameters.AddWithValue("@title", project.title);
                    comm.Parameters.AddWithValue("@description", project.description);
                    comm.Parameters.AddWithValue("@date_created", DateTime.Now.Date);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _projectId = reader.GetInt32(0);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            return _projectId;
        }
    }
}
