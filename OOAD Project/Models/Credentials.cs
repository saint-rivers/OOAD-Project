using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    public class Credentials
    {
        public Credentials() { }

        public Credentials(int id, string firstname, string lastname, string email, string secret)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.secret = secret;
        }

        public Credentials(string firstname, string lastname, string email, string secret)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.secret = secret;
        }

        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string secret { get; set; }
    }
}
