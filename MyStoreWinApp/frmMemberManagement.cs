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
    public partial class frmMemberManagement : Form
    {
        public bool isAdmin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement() => InitializeComponent();


        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                cboCountry.Enabled = false;
                cboCity.Enabled = false;
                txtEmail.Enabled = false;
                txtMemberID.Enabled = false;
                txtMemberName.Enabled = false;
                txtPassword.Enabled = false;
                btnFilter.Enabled = false;
                cboCountryF.Enabled = false;
                cboCityF.Enabled = false;
                txtSearch.Enabled = false;
                dgvMemberList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
                dgvMemberList.CellDoubleClick += DgvMemberList;
            }
        }

        private void DgvMemberList(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update",
                InsertOrUpdate = true,
                MemberObject = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
                source.Position = source.Count - 1;
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Email = txtEmail.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return memberObject;
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMember();
        }
        public void LoadMember()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.MemberName);
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                cboCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cboCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboCity.DataBindings.Add("Text", source, "City");
                cboCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (isAdmin == false)
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            cboCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboCity.Text = string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "New Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    memberRepository.DeleteMember(member.MemberID);
                    LoadMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }
        private void LoadSearch()
        {
            MemberObject member = new MemberObject();
            var members = memberRepository.GetMembers();
            try
            {
                foreach (var item in members)
                {
                    if (item.MemberName.Equals(txtSearch.Text))
                    {
                        source = new BindingSource();
                        source.DataSource = memberRepository.GetMemberByID(item.MemberID);
                        txtMemberID.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCity.DataBindings.Add("Text", source, "City");
                        cboCountry.DataBindings.Add("Text", source, "Country");

                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;
                        break;
                    }
                    else if (item.MemberID.ToString().Equals(txtSearch.Text))
                    {
                        source = new BindingSource();
                        source.DataSource = memberRepository.GetMemberByID(item.MemberID);
                        txtMemberID.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCity.DataBindings.Add("Text", source, "City");
                        cboCountry.DataBindings.Add("Text", source, "Country");

                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }
        private void LoadFilter()
        {
            MemberObject member = new MemberObject();
            List<MemberObject> list = memberRepository.GetMemberByCityAndCountry(cboCityF.Text, cboCountryF.Text);
            try
            {
                if(list.Count == 0)
                {
                    MessageBox.Show("No member");
                }
                else
                {
                    source = new BindingSource();
                    source.DataSource = list.OrderByDescending(member => member.MemberName);
                    txtMemberID.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtMemberName.DataBindings.Clear();
                    cboCountry.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    cboCity.DataBindings.Clear();

                    txtMemberID.DataBindings.Add("Text", source, "MemberID");
                    txtMemberName.DataBindings.Add("Text", source, "MemberName");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    cboCity.DataBindings.Add("Text", source, "City");
                    cboCountry.DataBindings.Add("Text", source, "Country");

                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                    
                }
            }catch(Exception ex)
            {

            }
        }
    }
}
