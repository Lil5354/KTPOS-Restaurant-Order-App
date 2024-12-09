namespace KTPOS_Order.Customer_Control
{
    partial class UC_OrderFood
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
            this.FlowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel16 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel16.SuspendLayout();
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
            "Best Sellers",
            "New Arrivals",
            "Featured Dishes",
            "Combo Deals",
            "Most Loved"});
            this.Filter.Location = new System.Drawing.Point(1195, 50);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(211, 36);
            this.Filter.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(507, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 31);
            this.guna2HtmlLabel1.TabIndex = 29;
            this.guna2HtmlLabel1.Text = "MENU";
            // 
            // FlowMenu
            // 
            this.FlowMenu.AutoScroll = true;
            this.FlowMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowMenu.BackColor = System.Drawing.Color.Transparent;
            this.FlowMenu.Location = new System.Drawing.Point(507, 126);
            this.FlowMenu.Name = "FlowMenu";
            this.FlowMenu.Size = new System.Drawing.Size(899, 501);
            this.FlowMenu.TabIndex = 32;
            this.FlowMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowMenu_Paint);
            this.FlowMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FlowMenu_MouseClick);
            this.FlowMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FlowMenu_MouseDoubleClick);
            // 
            // guna2CustomGradientPanel16
            // 
            this.guna2CustomGradientPanel16.AutoSize = true;
            this.guna2CustomGradientPanel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel16.BackgroundImage = global::KTPOS_Order.Properties.Resources._26df8325fe115cf3f8c0fd7a99c74108;
            this.guna2CustomGradientPanel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CustomGradientPanel16.BorderColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.BorderRadius = 15;
            this.guna2CustomGradientPanel16.Controls.Add(this.listView);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2Button15);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2HtmlLabel30);
            this.guna2CustomGradientPanel16.FillColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor3 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor4 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.Location = new System.Drawing.Point(39, 126);
            this.guna2CustomGradientPanel16.Name = "guna2CustomGradientPanel16";
            this.guna2CustomGradientPanel16.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel16.Size = new System.Drawing.Size(391, 454);
            this.guna2CustomGradientPanel16.TabIndex = 32;
            this.guna2CustomGradientPanel16.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel16_Paint);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(54, 93);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(283, 268);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            // 
            // guna2Button15
            // 
            this.guna2Button15.Animated = true;
            this.guna2Button15.AutoRoundedCorners = true;
            this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button15.BorderRadius = 30;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.White;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.Maroon;
            this.guna2Button15.Location = new System.Drawing.Point(95, 380);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(213, 62);
            this.guna2Button15.TabIndex = 2;
            this.guna2Button15.Text = "Order";
            this.guna2Button15.UseTransparentBackground = true;
            this.guna2Button15.Click += new System.EventHandler(this.guna2Button15_Click);
            // 
            // guna2HtmlLabel30
            // 
            this.guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel30.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel30.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel30.Location = new System.Drawing.Point(133, 26);
            this.guna2HtmlLabel30.Name = "guna2HtmlLabel30";
            this.guna2HtmlLabel30.Size = new System.Drawing.Size(103, 38);
            this.guna2HtmlLabel30.TabIndex = 3;
            this.guna2HtmlLabel30.Text = "RECEIPT";
            // 
            // UC_OrderFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel16);
            this.Controls.Add(this.FlowMenu);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UC_OrderFood";
            this.Size = new System.Drawing.Size(1454, 722);
            this.Load += new System.EventHandler(this.UC_OrderFood_Load_1);
            this.guna2CustomGradientPanel16.ResumeLayout(false);
            this.guna2CustomGradientPanel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox Filter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.FlowLayoutPanel FlowMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel16;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel30;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
