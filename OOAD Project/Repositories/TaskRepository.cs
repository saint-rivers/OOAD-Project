using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOAD_Project.Repositories
{
    public class TaskRepository : BaseRepository
    {
        public TaskRepository() : base()
        {

        }

        public List<ProjectTask> FetchTasksOfProject(int projectId)
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
                    comm.Parameters.AddWithValue("@project_id", projectId);
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
            return tasks;
        }

       

        public void InsertNewTask(int projectId, ProjectTask task)
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
                    comm.Parameters.AddWithValue("@pid", projectId);
                    comm.Parameters.AddWithValue("@assignedto", task.assignedToId);
                    comm.Parameters.AddWithValue("@title", task.title);
                    comm.Parameters.AddWithValue("@description", task.description);
                    comm.Parameters.AddWithValue("@deadline", task.deadline);
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
        }
    }
}
