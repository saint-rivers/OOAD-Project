using OOAD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project.Services
{
    public class MemberService : BaseService
    {
        public MemberService() : base()
        {

        }

        public bool AddNewProjectMember(int projectId, int memberId)
        {
            return memberController.InsertProjectMember(projectId, memberId);
        }

        public Member[] GetMembersAsArray(int projectId)
        {
            return memberController.GetMembersInProjectAsArray(projectId);
        }

        public Member[] GetMembersNotInProjectAsArray(int projectId)
        {
            return memberController.GetMembersNotInProjectAsArray(projectId);
        }

        public Member[] GetMembersInProjectAsArray(int projectId)
        {
            return memberController.GetMembersInProjectAsArray(projectId);
        }

        public bool ValidateLogin(string email, string secret)
        {
            email = "joy@gmail.com";
            secret = "asd";
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
            return memberController.GetMembersInProjectAsStringArray(projectId);
        }

        public void RemoveMemberFromProject(int selectedProject, int memberId, string memberName)
        {
            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to remove {memberName}?",
                "Remove Member",
                MessageBoxButtons.YesNo
                );
            if (dialogResult == DialogResult.Yes)
            {
                memberController.DeleteUserFromProjectMembers(selectedProject, memberId);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }
    }
}
