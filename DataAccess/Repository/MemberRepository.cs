using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);

        public List<MemberObject> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);

        public MemberObject GetMemberByID(int memId) => MemberDAO.Instance.GetMemberById(memId);

        public MemberObject GetMemberByName(string memName) => MemberDAO.Instance.getMemberByName(memName);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList;

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    }
}
