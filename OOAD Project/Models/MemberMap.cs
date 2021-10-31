using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Project.Models
{
    public class MemberMap
    {
        private Dictionary<int,string> memberMap;

        public MemberMap()
        {
            memberMap = new Dictionary<int,string>();
        }

        public bool IsEmpty()
        {
            return memberMap.Count == 0;
        }

        public void Clear()
        {
            memberMap.Clear();
        }

        public MemberMap(Member[] members)
        {
            memberMap = new Dictionary<int, string>();
            AddMemberRange(members);
        }

        public void AddMember(Member member)
        {
            string user = member.firstname + " " + member.lastname;
            memberMap.Add(member.id, user);
        }

        public string[] GetMembersAsNameArray()
        {
            return memberMap.Values.ToArray();
        }

        public void AddMemberRange(Member[] members)
        {
            foreach (Member member in members)
            {
                AddMember(member);
            }
        }

        public void SetMembers(Member[] members)
        {
            Clear();
            AddMemberRange(members);
        }

        public string GetMember(int id)
        {
            return memberMap[id];
        }

        public int GetIdByName(string name)
        {
            return memberMap.FirstOrDefault(x => x.Value == name).Key;
        }
    }
}
