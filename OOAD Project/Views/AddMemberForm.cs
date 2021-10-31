using OOAD_Project.Models;
using OOAD_Project.Services;
using OOAD_Project.Views;
using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    public partial class AddMemberForm : PForm
    {
        MemberMap memberMap;
        private int projectId;

        public AddMemberForm(int projectId, MemberService memberService)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.memberService = memberService;
            memberMap = new MemberMap();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            Member[] _members = memberService.GetMembersNotInProjectAsArray(projectId);
            memberMap.AddMemberRange(_members);
            nonMembersListBox.Items.AddRange(memberMap.GetMembersAsNameArray());
            nonMembersListBox.SelectedIndex = 0;
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            if (memberMap.IsEmpty())
            {
                return;
            }
            string selectedMember = nonMembersListBox.SelectedItem.ToString();
            int memberId = memberMap.GetIdByName(selectedMember);
            memberService.AddNewProjectMember(projectId, memberId);
            MessageBox.Show("Added new member.");
            Close();
        }
    }
}
