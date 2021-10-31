using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    public class ProjectTask
    {
        public ProjectTask(int projectId, string name, string description, int assignedTo, DateTime deadline)
        {
            this.projectId = projectId; 
            this.name = name;   
            this.description = description;
            this.assignedTo = assignedTo;
            this.deadline = deadline;
            isCompleted = false;
        }

        public int id { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int assignedTo { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime deadline { get; set; }
        public bool isCompleted { get; set; }
    }
}
