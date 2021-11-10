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
        protected ProjectRepository projectRepository;
        protected MemberRepository memberRepository;
        protected TaskRepository taskRepository;

        public BaseService()
        {
            projectRepository = new ProjectRepository();
            memberRepository = new MemberRepository();
            taskRepository = new TaskRepository();
        }
    }
}
