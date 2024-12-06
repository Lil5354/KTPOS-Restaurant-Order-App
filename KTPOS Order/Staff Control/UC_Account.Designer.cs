namespace KTPOS_Order.Staff_Control
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("wefef", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("efewfe", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ergreg", System.Windows.Forms.HorizontalAlignment.Left);
            this.Account = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Name,
            this.DOB,
            this.Gender,
            this.Email,
            this.PhoneNumber,
            this.Address});
            this.Account.GridLines = true;
            listViewGroup1.Header = "wefef";
            listViewGroup1.Name = "etgg";
            listViewGroup2.Header = "efewfe";
            listViewGroup2.Name = "wefewf";
            listViewGroup3.Header = "ergreg";
            listViewGroup3.Name = "rthrht";
            this.Account.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.Account.HideSelection = false;
            this.Account.Location = new System.Drawing.Point(33, 51);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(1068, 503);
            this.Account.TabIndex = 0;
            this.Account.UseCompatibleStateImageBehavior = false;
            this.Account.View = System.Windows.Forms.View.Details;
            this.Account.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "NO.";
            this.No.Width = 36;
            // 
            // DOB
            // 
            this.DOB.Text = "Date of Birth";
            this.DOB.Width = 170;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 87;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 170;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Width = 163;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 216;
            // 
            // Name
            // 
            this.Name.Text = "Full Name";
            this.Name.Width = 219;
            // 
            // UC_Account
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Account);
            this.Size = new System.Drawing.Size(1129, 751);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Account;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Name;
    }
}
