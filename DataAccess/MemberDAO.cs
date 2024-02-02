using BusinessObject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID=1, MemberName="PhuongAnh",
                Email="phuonganh@fpt.edu.vn", City="Hai Duong", Country="Viet Nam", Password="123456"},

            new MemberObject{MemberID=2, MemberName="Thanh",
                Email="thanh@fpt.edu.vn", City="Ha Tinh", Country="Viet Nam", Password="123456"},
            new MemberObject{MemberID=3, MemberName="Khanh Huyen",
                Email="huyen@fpt.edu.vn", City="Ha Noi", Country="Viet Nam", Password="123456"}
        };
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //-----------------------------------------------------
        //get MemberList
        public List<MemberObject> GetMemberList => MemberList;
        //get Member by Id
        public MemberObject GetMemberById(int memberID)
        {
            MemberObject member = MemberList.SingleOrDefault(pro=>pro.MemberID == memberID);
            return member;
        }
        //getMember by name 
        public MemberObject getMemberByName(string memberName)
        {
            MemberObject member = MemberList.SingleOrDefault(pro=>pro.MemberName == memberName);
            return member;
        }
        //add new member
        public void AddNew(MemberObject member)
        {
            MemberObject pro = GetMemberById(member.MemberID);

            if(pro == null) { 
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists");
            }
        }
        //update a member
        public void Update(MemberObject member)
        {
            MemberObject u = GetMemberById(member.MemberID);
            if(u != null)
            {
                var index = MemberList.IndexOf(u);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        //remove a member
        public void Remove(int MemberID)
        {
            MemberObject d = GetMemberById(MemberID);
            if(d != null)
            {
                MemberList.Remove(d);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }

        public List<MemberObject> GetMemberByCityAndCountry(string city, string country)
        {
            List<MemberObject> list = new List<MemberObject>();
            for(int i = 0; i < MemberList.Count; i++)
            {
                if (MemberList[i].City == city && MemberList[i].Country == country)
                {
                    list.Add(MemberList[i]);
                }
            }
            return list;
        }
    }
}
