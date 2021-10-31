using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Services
{
    public class MemberService : BaseService
    {
        public MemberService() : base()
        {

        }

        public bool ValidateLogin(string email, string secret)
        {
            return memberController.ValidateLogin(email, secret);
        }

        public int GetCurrentUserId()
        {
            return memberController.currentUser.id;
        }

        public Member GetCurrentUser()
        {
            return memberController.currentUser;
        }

        public Member GetValidatedUser()
        {
            return memberController.GetValidatedUser();
        }

        public string[] GetProjectMembers(int projectId)
        {
            return memberController.GetProjectMembers(projectId);
        }
    }
}
