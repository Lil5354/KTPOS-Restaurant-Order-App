namespace KTPOS_Order.Customer_Control
{
    partial class UC_Item
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
            this.btnItem = new Guna.UI2.WinForms.Guna2Button();
            this.txtCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.Animated = true;
            this.btnItem.BorderColor = System.Drawing.Color.Maroon;
            this.btnItem.BorderRadius = 20;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItem.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnItem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnItem.FillColor = System.Drawing.Color.White;
            this.btnItem.FocusedColor = System.Drawing.Color.White;
            this.btnItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.btnItem.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.btnItem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnItem.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnItem.Location = new System.Drawing.Point(0, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(160, 196);
            this.btnItem.TabIndex = 0;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.AutoSize = false;
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.DimGray;
            this.txtCost.Location = new System.Drawing.Point(3, 145);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 30);
            this.txtCost.TabIndex = 3;
            this.txtCost.Text = "$10.5";
            this.txtCost.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.AutoSize = false;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(3, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 33);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "H";
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KTPOS_Order.Properties.Resources.hamburger2;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(18, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(128, 88);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // UC_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnItem);
            this.Name = "UC_Item";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(160, 196);
            this.Load += new System.EventHandler(this.UC_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCost;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
