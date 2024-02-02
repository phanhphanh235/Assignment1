using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberObject { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            //cboCity.SelectedIndex = 0;
            txtMemberID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtMemberID.Text = MemberObject.MemberID.ToString();
                txtMemberName.Text = MemberObject.MemberName;
                cboCity.Text = MemberObject.City;
                cboCountry.Text = MemberObject.Country;
                txtEmail.Text = MemberObject.Email;
                txtPassword.Text = MemberObject.Password;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text
                };
                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
