namespace KTPOS_Order
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Guna2Button btnClose;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new Guna.UI2.WinForms.Guna2Button();
            this.btnEyes = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaxSize = new Guna.UI2.WinForms.Guna2Button();
            this.TableChange = new Guna.UI2.WinForms.Guna2ComboBox();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btnClose.Animated = true;
            btnClose.AutoRoundedCorners = true;
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.BackgroundImage = global::KTPOS_Order.Properties.Resources.xmark_solid;
            btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClose.BorderRadius = 11;
            btnClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnClose.FillColor = System.Drawing.Color.Transparent;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnClose.ForeColor = System.Drawing.Color.Transparent;
            btnClose.Location = new System.Drawing.Point(633, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(25, 25);
            btnClose.TabIndex = 9;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BackgroundImage = global::KTPOS_Order.Properties.Resources._1ddf7dbc9b47c8dab0a1456ae07ac4c6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnEyes);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(127, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 262);
            this.panel1.TabIndex = 2;
            // 
            // btnHide
            // 
            this.btnHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHide.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Image = global::KTPOS_Order.Properties.Resources.eye_slash_solid;
            this.btnHide.Location = new System.Drawing.Point(228, 111);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 30);
            this.btnHide.TabIndex = 21;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnEyes
            // 
            this.btnEyes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEyes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEyes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEyes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEyes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEyes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEyes.ForeColor = System.Drawing.Color.White;
            this.btnEyes.Image = global::KTPOS_Order.Properties.Resources.eye_solid;
            this.btnEyes.Location = new System.Drawing.Point(228, 111);
            this.btnEyes.Name = "btnEyes";
            this.btnEyes.Size = new System.Drawing.Size(30, 30);
            this.btnEyes.TabIndex = 20;
            this.btnEyes.Click += new System.EventHandler(this.btnEyes_Click_2);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Maroon;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(145, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 44);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 21;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(26, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.AutoRoundedCorners = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderColor = System.Drawing.Color.Maroon;
            this.txtPass.BorderRadius = 19;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.IconLeft = global::KTPOS_Order.Properties.Resources.key_solid;
            this.txtPass.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPass.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPass.Location = new System.Drawing.Point(26, 106);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(243, 40);
            this.txtPass.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Animated = true;
            this.txtUser.AutoRoundedCorners = true;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderColor = System.Drawing.Color.Maroon;
            this.txtUser.BorderRadius = 19;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconLeft = global::KTPOS_Order.Properties.Resources.user_solid;
            this.txtUser.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUser.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtUser.Location = new System.Drawing.Point(26, 41);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.txtUser.PlaceholderText = "User Name";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(243, 40);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnMinSize
            // 
            this.btnMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinSize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinSize.BackgroundImage = global::KTPOS_Order.Properties.Resources.window_restore_solid__1_;
            this.btnMinSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinSize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinSize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinSize.Location = new System.Drawing.Point(602, 21);
            this.btnMinSize.Name = "btnMinSize";
            this.btnMinSize.Size = new System.Drawing.Size(25, 25);
            this.btnMinSize.TabIndex = 20;
            this.btnMinSize.Click += new System.EventHandler(this.btnMinSize_Click);
            // 
            // btnMaxSize
            // 
            this.btnMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxSize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxSize.BackgroundImage = global::KTPOS_Order.Properties.Resources.window_maximize_solid;
            this.btnMaxSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaxSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaxSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaxSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaxSize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaxSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaxSize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaxSize.Location = new System.Drawing.Point(602, 21);
            this.btnMaxSize.Name = "btnMaxSize";
            this.btnMaxSize.Size = new System.Drawing.Size(25, 25);
            this.btnMaxSize.TabIndex = 21;
            this.btnMaxSize.Click += new System.EventHandler(this.btnMaxSize_Click);
            // 
            // TableChange
            // 
            this.TableChange.BackColor = System.Drawing.Color.Transparent;
            this.TableChange.BorderColor = System.Drawing.Color.Maroon;
            this.TableChange.BorderRadius = 7;
            this.TableChange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TableChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableChange.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TableChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TableChange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TableChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TableChange.ItemHeight = 30;
            this.TableChange.Items.AddRange(new object[] {
            "Guest",
            "Staff"});
            this.TableChange.Location = new System.Drawing.Point(29, 21);
            this.TableChange.Name = "TableChange";
            this.TableChange.Size = new System.Drawing.Size(127, 36);
            this.TableChange.TabIndex = 39;
            this.TableChange.SelectedIndexChanged += new System.EventHandler(this.TableChange_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::KTPOS_Order.Properties.Resources.shutterstock_1088296091;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.TableChange);
            this.Controls.Add(this.btnMaxSize);
            this.Controls.Add(this.btnMinSize);
            this.Controls.Add(btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton btnLogin;
        private Guna.UI2.WinForms.Guna2TileButton btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnHide;
        private Guna.UI2.WinForms.Guna2Button btnEyes;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnMinSize;
        private Guna.UI2.WinForms.Guna2Button btnMaxSize;
        private Guna.UI2.WinForms.Guna2ComboBox TableChange;
    }
}