﻿namespace KTPOS_Order
{
    partial class fStaff
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
            Guna.UI2.WinForms.Guna2Button btnClose;
            this.btnMaxSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnProccessing = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableManage = new Guna.UI2.WinForms.Guna2Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
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
            btnClose.Location = new System.Drawing.Point(1101, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(25, 25);
            btnClose.TabIndex = 21;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnMaxSize.Location = new System.Drawing.Point(1059, 12);
            this.btnMaxSize.Name = "btnMaxSize";
            this.btnMaxSize.Size = new System.Drawing.Size(25, 25);
            this.btnMaxSize.TabIndex = 23;
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
            this.btnMinSize.Location = new System.Drawing.Point(1059, 18);
            this.btnMinSize.Name = "btnMinSize";
            this.btnMinSize.Size = new System.Drawing.Size(25, 25);
            this.btnMinSize.TabIndex = 22;
            // 
            // btnChat
            // 
            this.btnChat.Animated = true;
            this.btnChat.AutoRoundedCorners = true;
            this.btnChat.BackColor = System.Drawing.Color.Transparent;
            this.btnChat.BorderRadius = 25;
            this.btnChat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnChat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChat.FillColor = System.Drawing.Color.Transparent;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnChat.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnChat.HoverState.FillColor = System.Drawing.Color.White;
            this.btnChat.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnChat.Location = new System.Drawing.Point(421, 18);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(102, 52);
            this.btnChat.TabIndex = 30;
            this.btnChat.Text = "Chat";
            this.btnChat.UseTransparentBackground = true;
            // 
            // btnManage
            // 
            this.btnManage.Animated = true;
            this.btnManage.AutoRoundedCorners = true;
            this.btnManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManage.BorderRadius = 25;
            this.btnManage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManage.FillColor = System.Drawing.Color.Transparent;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnManage.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnManage.HoverState.FillColor = System.Drawing.Color.White;
            this.btnManage.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnManage.Location = new System.Drawing.Point(565, 18);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(148, 52);
            this.btnManage.TabIndex = 29;
            this.btnManage.Text = "Management";
            this.btnManage.UseTransparentBackground = true;
            // 
            // btnProccessing
            // 
            this.btnProccessing.Animated = true;
            this.btnProccessing.AutoRoundedCorners = true;
            this.btnProccessing.BackColor = System.Drawing.Color.Transparent;
            this.btnProccessing.BorderRadius = 25;
            this.btnProccessing.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnProccessing.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProccessing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProccessing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProccessing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProccessing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProccessing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProccessing.FillColor = System.Drawing.Color.Transparent;
            this.btnProccessing.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProccessing.ForeColor = System.Drawing.Color.White;
            this.btnProccessing.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnProccessing.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnProccessing.HoverState.FillColor = System.Drawing.Color.White;
            this.btnProccessing.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnProccessing.Location = new System.Drawing.Point(267, 18);
            this.btnProccessing.Name = "btnProccessing";
            this.btnProccessing.Size = new System.Drawing.Size(123, 52);
            this.btnProccessing.TabIndex = 27;
            this.btnProccessing.Text = "Proccessing";
            // 
            // btnTableManage
            // 
            this.btnTableManage.Animated = true;
            this.btnTableManage.AutoRoundedCorners = true;
            this.btnTableManage.BackColor = System.Drawing.Color.Transparent;
            this.btnTableManage.BorderRadius = 25;
            this.btnTableManage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnTableManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTableManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableManage.FillColor = System.Drawing.Color.Transparent;
            this.btnTableManage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTableManage.ForeColor = System.Drawing.Color.White;
            this.btnTableManage.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTableManage.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnTableManage.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTableManage.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnTableManage.Location = new System.Drawing.Point(34, 18);
            this.btnTableManage.Name = "btnTableManage";
            this.btnTableManage.Size = new System.Drawing.Size(207, 52);
            this.btnTableManage.TabIndex = 26;
            this.btnTableManage.Text = "Table Management";
            this.btnTableManage.Click += new System.EventHandler(this.btnListBill_Click);
            // 
            // fStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::KTPOS_Order.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1169, 740);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnProccessing);
            this.Controls.Add(this.btnTableManage);
            this.Controls.Add(this.btnMaxSize);
            this.Controls.Add(this.btnMinSize);
            this.Controls.Add(btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaff";
            this.Text = "Staff ";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMaxSize;
        private Guna.UI2.WinForms.Guna2Button btnMinSize;
        private Guna.UI2.WinForms.Guna2Button btnChat;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private Guna.UI2.WinForms.Guna2Button btnProccessing;
        private Guna.UI2.WinForms.Guna2Button btnTableManage;
    }
}