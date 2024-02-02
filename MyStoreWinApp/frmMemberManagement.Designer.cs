namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbMemberID = new Label();
            lbMemberName = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            lbEmail = new Label();
            lbCountry = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            lbCity = new Label();
            txtPassword = new TextBox();
            dgvMemberList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnClose = new Button();
            btnFilter = new Button();
            cboCityF = new ComboBox();
            cboCountryF = new ComboBox();
            txtSearch = new TextBox();
            cboCountry = new ComboBox();
            cboCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 20);
            label1.Name = "label1";
            label1.Size = new Size(333, 41);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(37, 95);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "MemberID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(423, 95);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(121, 88);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(218, 27);
            txtMemberID.TabIndex = 3;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(538, 88);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(218, 27);
            txtMemberName.TabIndex = 4;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(37, 144);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(423, 148);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 2;
            lbCountry.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(37, 206);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(423, 206);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 2;
            lbCity.Text = "City";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 3;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(39, 385);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(717, 180);
            dgvMemberList.TabIndex = 5;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(148, 337);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(350, 337);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(529, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(662, 248);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(350, 587);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(529, 288);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cboCityF
            // 
            cboCityF.FormattingEnabled = true;
            cboCityF.Items.AddRange(new object[] { "Ha Noi", "Hai Duong", "Ha Tinh", "Thai Binh", "Ho Chi Minh", "Da Nang", "Can Tho" });
            cboCityF.Location = new Point(121, 289);
            cboCityF.Name = "cboCityF";
            cboCityF.Size = new Size(151, 28);
            cboCityF.TabIndex = 7;
            // 
            // cboCountryF
            // 
            cboCountryF.FormattingEnabled = true;
            cboCountryF.Items.AddRange(new object[] { "Viet Nam", "Unites State", "ThaiLand", "Campuchia", "Laos", "Singapore", "China", "Japan", "Korea" });
            cboCountryF.Location = new Point(318, 289);
            cboCountryF.Name = "cboCountryF";
            cboCountryF.Size = new Size(151, 28);
            cboCountryF.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(121, 248);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(502, 27);
            txtSearch.TabIndex = 8;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "Unites State", "ThaiLand", "Campuchia", "Laos", "Singapore", "China", "Japan", "Korea" });
            cboCountry.Location = new Point(538, 141);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(218, 28);
            cboCountry.TabIndex = 7;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ha Noi", "Hai Duong", "Ha Tinh", "Thai Binh", "Ho Chi Minh", "Da Nang", "Can Tho" });
            cboCity.Location = new Point(538, 198);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(218, 28);
            cboCity.TabIndex = 7;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(txtSearch);
            Controls.Add(cboCountryF);
            Controls.Add(cboCity);
            Controls.Add(cboCountry);
            Controls.Add(cboCityF);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(btnFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtMemberName);
            Controls.Add(txtPassword);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(txtMemberID);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Controls.Add(label1);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbMemberID;
        private Label lbMemberName;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private Label lbEmail;
        private Label lbCountry;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private Label lbPassword;
        private Label lbCity;
        private TextBox txtPassword;
        private TextBox txtCity;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnClose;
        private Button btnFilter;
        private ComboBox cboCity;
        private ComboBox cboCountryF;
        private TextBox txtSearch;
        private ComboBox cboCountry;
        private ComboBox cboCityF;
    }
}