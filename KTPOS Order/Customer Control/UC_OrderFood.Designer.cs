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
            this.FlowMenu = new System.Windows.Forms.FlowLayoutPanel();
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
            this.Filter.Location = new System.Drawing.Point(616, 14);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(211, 36);
            this.Filter.TabIndex = 30;
            // 
            // FlowMenu
            // 
            this.FlowMenu.AutoScroll = true;
            this.FlowMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowMenu.BackColor = System.Drawing.Color.Transparent;
            this.FlowMenu.Location = new System.Drawing.Point(0, 56);
            this.FlowMenu.Name = "FlowMenu";
            this.FlowMenu.Size = new System.Drawing.Size(839, 501);
            this.FlowMenu.TabIndex = 32;
            this.FlowMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowMenu_Paint);
            // 
            // UC_OrderFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FlowMenu);
            this.Controls.Add(this.Filter);
            this.Name = "UC_OrderFood";
            this.Size = new System.Drawing.Size(850, 560);
            this.Load += new System.EventHandler(this.UC_OrderFood_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ComboBox Filter;
        public Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        public System.Windows.Forms.FlowLayoutPanel FlowMenu;
    }
}
