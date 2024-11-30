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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picFood = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BackgroundImage = global::KTPOS_Order.Properties.Resources._26df8325fe115cf3f8c0fd7a99c74108;
            this.guna2CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.BorderRadius = 15;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnOrder);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtName);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtCost);
            this.guna2CustomGradientPanel1.Controls.Add(this.picFood);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(2, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(160, 197);
            this.guna2CustomGradientPanel1.TabIndex = 44;
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BorderRadius = 14;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.Maroon;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(89, 152);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(58, 31);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Đặt";
            this.btnOrder.UseTransparentBackground = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(48, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(55, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Cúc teo";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Transparent;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic);
            this.txtCost.ForeColor = System.Drawing.Color.Black;
            this.txtCost.Location = new System.Drawing.Point(20, 156);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(48, 19);
            this.txtCost.TabIndex = 0;
            this.txtCost.Text = "45.000đ";
            // 
            // picFood
            // 
            this.picFood.Image = global::KTPOS_Order.Properties.Resources.cocktail;
            this.picFood.ImageRotate = 0F;
            this.picFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Name = "picFood";
            this.picFood.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picFood.Size = new System.Drawing.Size(160, 103);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 2;
            this.picFood.TabStop = false;
            this.picFood.UseTransparentBackground = true;
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(164, 200);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCost;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picFood;
    }
}
