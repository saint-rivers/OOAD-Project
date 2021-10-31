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
    public class TaskRepository : BaseRepository
    {
        public TaskRepository() : base()
        {

        }

        public void InsertNewTask(ProjectTask task)
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
                    comm.Parameters.AddWithValue("@pid", task.id);
                    comm.Parameters.AddWithValue("@assignedto", task.assignedTo);
                    comm.Parameters.AddWithValue("@title", task.name);
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
