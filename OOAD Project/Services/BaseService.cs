using OOAD_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Services
{
    public class BaseService
    {
        protected ProjectRepository projectController;
        protected MemberRepository memberController;
        protected TaskRepository taskRepository;

        public BaseService()
        {
            projectController = new ProjectRepository();
            memberController = new MemberRepository();
            taskRepository = new TaskRepository();
        }
    }
}
