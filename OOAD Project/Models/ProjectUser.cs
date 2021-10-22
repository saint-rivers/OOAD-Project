using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    public class ProjectUser
    {
        public ProjectUser() { }

        public ProjectUser(int userId, string firstname, string lastname, string email)
        {
            this.id = userId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public int UserId { get; }
    }
}
