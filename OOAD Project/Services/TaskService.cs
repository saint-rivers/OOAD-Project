using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Services
{
    public class TaskService : BaseService
    {
        public TaskService() : base()
        {
            
        }

        public void InsertNewTask(ProjectTask task)
        {
            taskRepository.InsertNewTask(task);
        }

        public List<ProjectTask> FetchTasksOfProject(int projectId)
        {
            return taskRepository.FetchTasksOfProject(projectId);
        }


    }
}
