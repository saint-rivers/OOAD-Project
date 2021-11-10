using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    public class ProjectTask
    {
        public ProjectTask()
        {

        }

        public ProjectTask(int projectId, string title, string description, int assignedToId, DateTime deadline)
        {
            this.projectId = projectId;
            this.title = title;
            this.description = description;
            this.assignedToId = assignedToId;
            this.deadline = deadline;
        }

        public int id { get; set; }
        public int projectId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int assignedToId { get; set; }
        public string assignedToName { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime deadline { get; set; }
        public bool isCompleted { get; set; }
        public string email { get; set; }
    }
}
