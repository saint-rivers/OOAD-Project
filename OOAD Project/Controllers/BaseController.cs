using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Controllers
{
    public class BaseController
    {
        public static string GetConnectionString()
        {
            return Properties.Settings.Default.ProjectManagementConnectionString;
        }
    }
}
