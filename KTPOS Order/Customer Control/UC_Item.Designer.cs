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
            this.Food1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtGradient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Food1
            // 
            this.Food1.BorderRadius = 20;
            this.Food1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Food1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Food1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Food1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Food1.FillColor = System.Drawing.Color.White;
            this.Food1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Food1.ForeColor = System.Drawing.Color.White;
            this.Food1.Location = new System.Drawing.Point(0, 0);
            this.Food1.Name = "Food1";
            this.Food1.Size = new System.Drawing.Size(160, 196);
            this.Food1.TabIndex = 0;
            this.Food1.Click += new System.EventHandler(this.Food1_Click);
            this.Food1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Food1_MouseClick);
            // 
            // txtGradient
            // 
            this.txtGradient.BackColor = System.Drawing.Color.White;
            this.txtGradient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradient.ForeColor = System.Drawing.Color.Maroon;
            this.txtGradient.Location = new System.Drawing.Point(14, 115);
            this.txtGradient.Name = "txtGradient";
            this.txtGradient.Size = new System.Drawing.Size(34, 23);
            this.txtGradient.TabIndex = 2;
            this.txtGradient.Text = "Beef";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.DimGray;
            this.txtCost.Location = new System.Drawing.Point(86, 115);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(43, 23);
            this.txtCost.TabIndex = 3;
            this.txtCost.Text = "$10.5";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 146);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 27);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Hamburger";
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
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // UC_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtGradient);
            this.Controls.Add(this.Food1);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(174, 208);
            this.Load += new System.EventHandler(this.UC_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Food1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtGradient;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCost;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
