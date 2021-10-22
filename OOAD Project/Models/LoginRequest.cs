using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Models
{
    class LoginRequest
    {
        public LoginRequest(string email, string secret)
        {
            this.email = email;
            this.secret = secret;
        }

        public string email { get; set; }
        public string secret { get; set; }
    }
}
