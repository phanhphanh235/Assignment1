using BusinessObject;
using DataAccess.Repository;
using Nancy.Json;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader("appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            //convert
            var obj = jss.Deserialize<dynamic>(json);
            var admin = new MemberObject
            {
                Email = obj["DefaultAccount"]["Email"],
                Password = obj["DefaultAccount"]["password"]
            };
            var members = memberRepository.GetMembers();
            bool isMem = false;
            foreach (var item in members)
            {
                if (item.MemberName.Equals(txtUser.Text) && item.Password.Equals(txtPass.Text))
                {
                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = false
                    };
                    frm.ShowDialog();
                    isMem = true;
                    this.Close();
                    break;
                }
                else if (admin.Email.Equals(txtUser.Text) && admin.Password.Equals(txtPass.Text))
                {
                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = true
                    };
                    frm.ShowDialog();
                    isMem = true;
                    this.Close();
                    break;
                }
            }
            if (isMem == true)
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Login fail, enter email, password again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
