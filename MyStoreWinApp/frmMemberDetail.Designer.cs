namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbMemberName = new Label();
            txtMemberName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCountry = new Label();
            lbCity = new Label();
            cboCountry = new ComboBox();
            cboCity = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(63, 63);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(237, 56);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(224, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(63, 110);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(105, 20);
            lbMemberName.TabIndex = 0;
            lbMemberName.Text = "MemberName";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(237, 103);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(224, 27);
            txtMemberName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(63, 161);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(63, 217);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(237, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 27);
            txtPassword.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(63, 275);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(63, 328);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "Unites State", "ThaiLand", "Campuchia", "Laos", "Singapore", "China", "Japan", "Korea" });
            cboCountry.Location = new Point(237, 267);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(224, 28);
            cboCountry.TabIndex = 2;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ha Noi", "Hai Duong", "Ha Tinh", "Thai Binh", "Da Nang", "Can Tho", "Ho Chi Minh" });
            cboCity.Location = new Point(237, 320);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(224, 28);
            cboCity.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(141, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 562);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCity);
            Controls.Add(cboCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCountry;
        private Label lbCity;
        private ComboBox cboCountry;
        private ComboBox cboCity;
        private Button btnSave;
        private Button btnCancel;
    }
}