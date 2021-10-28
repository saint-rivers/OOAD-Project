using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    public class Project
    {
        public Project() { }

        public Project(string title, string description, int ownerId, DateTime dateCreated)
        {
            this.title = title;
            this.description = description;
            this.ownerId = ownerId;
            this.dateCreated = dateCreated;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int ownerId { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
