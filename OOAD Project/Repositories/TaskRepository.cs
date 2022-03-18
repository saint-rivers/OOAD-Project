using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOAD_Project.Repositories
{
    public class TaskRepository : BaseRepository<ProjectTask>
    {
        public TaskRepository() : base() {}

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectTask> FetchTasksOfProject(int projectId)
        {
            return new List<ProjectTask>(GetAllById(projectId));
        }

        public override ProjectTask[] GetAll()
        {
            List<ProjectTask> tasks = new List<ProjectTask>();
            string _connStr = GetConnectionString();
            string _query = @"SELECT t.Id, t.ProjectId, t.Title, t.Description, t.TimeCreated, t.Deadline, t.IsCompleted, 
	                            u.Firstname + SPACE(1) + u.Lastname as AssignedTo, u.Id as MemberId, u.Email as Email
                                FROM Tasks t
                                INNER JOIN ProjectUsers u 
                                ON t.AssignedTo = u.Id;";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    int result = comm.ExecuteNonQuery();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ProjectTask _task = new ProjectTask();

                                _task.id = reader.GetInt32(0);
                                _task.projectId = reader.GetInt32(1);
                                _task.title = reader.GetString(2);
                                _task.description = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                _task.timeCreated = reader.GetDateTime(4);
                                _task.deadline = reader.GetDateTime(5);
                                _task.isCompleted = reader.GetBoolean(6);
                                _task.assignedToName = reader.GetString(7);
                                _task.assignedToId = reader.GetInt32(8);
                                _task.email = reader.GetString(9);

                                tasks.Add(_task);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return tasks.ToArray();
        }

        public override ProjectTask[] GetAllById(int id)
        {
            List<ProjectTask> tasks = new List<ProjectTask>();
            string _connStr = GetConnectionString();
            string _query = @"SELECT t.Id, t.ProjectId, t.Title, t.Description, t.TimeCreated, t.Deadline, t.IsCompleted, 
	                            u.Firstname + SPACE(1) + u.Lastname as AssignedTo, u.Id as MemberId, u.Email as Email
                                FROM Tasks t
                                INNER JOIN ProjectUsers u 
                                ON t.AssignedTo = u.Id
                                WHERE t.ProjectId = @project_id;";

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand(_query, conn))
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@project_id", id);
                    int result = comm.ExecuteNonQuery();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ProjectTask _task = new ProjectTask();

                                _task.id = reader.GetInt32(0);
                                _task.projectId = reader.GetInt32(1);
                                _task.title = reader.GetString(2);
                                _task.description = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                _task.timeCreated = reader.GetDateTime(4);
                                _task.deadline = reader.GetDateTime(5);
                                _task.isCompleted = reader.GetBoolean(6);
                                _task.assignedToName = reader.GetString(7);
                                _task.assignedToId = reader.GetInt32(8);
                                _task.email = reader.GetString(9);

                                tasks.Add(_task);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
            return tasks.ToArray();
        }

        public override ProjectTask GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override ProjectTask Save(ProjectTask t)
        {
            string _connStr = Properties.Settings.Default.ProjectManagementConnectionString;
            string _query = "INSERT INTO Tasks (ProjectId, AssignedTo, Title, Description, Deadline, TimeCreated, IsCompleted) " +
                "values (@pid, @assignedto, @title, @description, @deadline, @time_created, @is_completed)";
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = _query;
                    comm.Parameters.AddWithValue("@pid", t.projectId);
                    comm.Parameters.AddWithValue("@assignedto", t.assignedToId);
                    comm.Parameters.AddWithValue("@title", t.title);
                    comm.Parameters.AddWithValue("@description", t.description);
                    comm.Parameters.AddWithValue("@deadline", t.deadline);
                    comm.Parameters.AddWithValue("@time_created", DateTime.Now);
                    comm.Parameters.AddWithValue("@is_completed", 0);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            // return GetById(t.id);
            return null;
        }
    }
}
