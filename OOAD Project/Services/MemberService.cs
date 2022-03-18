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
        public MemberService() : base() {}

        public void RegisterNewMember(Credentials credentials)
        {
            memberRepository.Save(credentials);
        }

        public bool AddNewProjectMember(int projectId, int memberId)
        {
            return memberRepository.InsertProjectMember(projectId, memberId);
        }

        public Member[] GetMembersAsArray(int projectId)
        {
            return memberRepository.GetMembersInProjectAsArray(projectId);
        }

        public Member[] GetMembersNotInProjectAsArray(int projectId)
        {
            return memberRepository.GetMembersNotInProjectAsArray(projectId);
        }

        public Member[] GetMembersInProjectAsArray(int projectId)
        {
            return memberRepository.GetMembersInProjectAsArray(projectId);
        }

        public bool ValidateLogin(string email, string secret)
        {
            return memberRepository.ValidateLogin(email, secret);
        }

        public int GetCurrentUserId()
        {
            return memberRepository.currentUser.id;
        }

        public Member GetCurrentUser()
        {
            return memberRepository.currentUser;
        }

        public Member GetValidatedUser()
        {
            return memberRepository.GetValidatedUser();
        }

        public string[] GetProjectMembers(int projectId)
        {
            return memberRepository.GetMembersInProjectAsStringArray(projectId);
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
                memberRepository.DeleteUserFromProjectMembers(selectedProject, memberId);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        public bool UpdateMemberCredentials(int memberId, Credentials newInfo)
        {
            return memberRepository.UpdateMemberCredentials(memberId, newInfo);
        }


    }
}
