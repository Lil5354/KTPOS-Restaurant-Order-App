namespace KTPOS_Order.Customer_Control
{
    partial class UC_OrderFoodOption
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
            this.Filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picFood = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.Transparent;
            this.Filter.BorderRadius = 7;
            this.Filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Filter.ItemHeight = 30;
            this.Filter.Items.AddRange(new object[] {
            "A-Z",
            "Bán chạy nhất",
            "Mới nhất"});
            this.Filter.Location = new System.Drawing.Point(669, 86);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(211, 36);
            this.Filter.TabIndex = 42;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(56, 64);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(101, 38);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "MENU";
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
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(56, 149);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(160, 197);
            this.guna2CustomGradientPanel1.TabIndex = 35;
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
            this.txtName.Size = new System.Drawing.Size(64, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Cucecule";
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
            this.picFood.Image = global::KTPOS_Order.Properties.Resources.coca;
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
            // UC_OrderFoodOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::KTPOS_Order.Properties.Resources.d62d6c72fbe203f5cf1061e28e17df67;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UC_OrderFoodOption";
            this.Size = new System.Drawing.Size(933, 755);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox Filter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCost;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picFood;
    }
}
