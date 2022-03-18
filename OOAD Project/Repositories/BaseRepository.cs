using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Repositories
{
    public abstract class BaseRepository<T>
    {
        public static string GetConnectionString()
        {
            return Properties.Settings.Default.ProjectManagementConnectionString;
        }

        public abstract T GetById(int id);
        public abstract T[] GetAll();
        public abstract T[] GetAllById(int id);
        public abstract T Save(T t);
        public abstract bool Delete(int id);
    }
}
