namespace KTPOS_Order.Staff_Control
{
    partial class UC_Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel16 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbForm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Bill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalAmount = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel16
            // 
            this.guna2CustomGradientPanel16.AutoSize = true;
            this.guna2CustomGradientPanel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel16.BackgroundImage = global::KTPOS_Order.Properties.Resources._26df8325fe115cf3f8c0fd7a99c74108;
            this.guna2CustomGradientPanel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CustomGradientPanel16.BorderColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.BorderRadius = 15;
            this.guna2CustomGradientPanel16.Controls.Add(this.lblTotalAmount);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel16.Controls.Add(this.cbForm);
            this.guna2CustomGradientPanel16.Controls.Add(this.Bill);
            this.guna2CustomGradientPanel16.Controls.Add(this.btnPay);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2HtmlLabel30);
            this.guna2CustomGradientPanel16.FillColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor3 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor4 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel16.Name = "guna2CustomGradientPanel16";
            this.guna2CustomGradientPanel16.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel16.Size = new System.Drawing.Size(443, 500);
            this.guna2CustomGradientPanel16.TabIndex = 33;
            this.guna2CustomGradientPanel16.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel16_Paint);
            // 
            // cbForm
            // 
            this.cbForm.BackColor = System.Drawing.Color.Transparent;
            this.cbForm.BorderRadius = 10;
            this.cbForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbForm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbForm.ItemHeight = 30;
            this.cbForm.Items.AddRange(new object[] {
            "Transfer",
            "Cash"});
            this.cbForm.Location = new System.Drawing.Point(37, 427);
            this.cbForm.Name = "cbForm";
            this.cbForm.Size = new System.Drawing.Size(154, 36);
            this.cbForm.TabIndex = 6;
            this.cbForm.SelectedIndexChanged += new System.EventHandler(this.cbForm_SelectedIndexChanged);
            // 
            // Bill
            // 
            this.Bill.AccessibleDescription = "Bill";
            this.Bill.AccessibleName = "Bill";
            this.Bill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Bill.ColumnHeadersHeight = 40;
            this.Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bill.DefaultCellStyle = dataGridViewCellStyle6;
            this.Bill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Bill.Location = new System.Drawing.Point(37, 115);
            this.Bill.Name = "Bill";
            this.Bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bill.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Bill.RowHeadersVisible = false;
            this.Bill.RowHeadersWidth = 51;
            this.Bill.RowTemplate.Height = 25;
            this.Bill.Size = new System.Drawing.Size(376, 238);
            this.Bill.TabIndex = 5;
            this.Bill.Tag = "Bill";
            this.Bill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.Bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Bill.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Maroon;
            this.Bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.Bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Bill.ThemeStyle.HeaderStyle.Height = 40;
            this.Bill.ThemeStyle.ReadOnly = false;
            this.Bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Maroon;
            this.Bill.ThemeStyle.RowsStyle.Height = 25;
            this.Bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.Bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "ITEM NAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "QTY";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "PRICE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 30;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.White;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Maroon;
            this.btnPay.Location = new System.Drawing.Point(237, 418);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(176, 62);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Payment";
            this.btnPay.UseTransparentBackground = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // guna2HtmlLabel30
            // 
            this.guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel30.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel30.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel30.Location = new System.Drawing.Point(158, 36);
            this.guna2HtmlLabel30.Name = "guna2HtmlLabel30";
            this.guna2HtmlLabel30.Size = new System.Drawing.Size(131, 47);
            this.guna2HtmlLabel30.TabIndex = 3;
            this.guna2HtmlLabel30.Text = "RECEIPT";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Animated = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.BorderColor = System.Drawing.Color.Maroon;
            this.lblTotalAmount.BorderRadius = 10;
            this.lblTotalAmount.BorderThickness = 1;
            this.lblTotalAmount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblTotalAmount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblTotalAmount.FillColor = System.Drawing.Color.White;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalAmount.Location = new System.Drawing.Point(281, 365);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(132, 36);
            this.lblTotalAmount.TabIndex = 51;
            this.lblTotalAmount.Text = "$500";
            this.lblTotalAmount.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(129, 365);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(66, 30);
            this.guna2HtmlLabel2.TabIndex = 50;
            this.guna2HtmlLabel2.Text = "TOTAL";
            // 
            // UC_Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2CustomGradientPanel16);
            this.Name = "UC_Payment";
            this.Size = new System.Drawing.Size(458, 522);
            this.guna2CustomGradientPanel16.ResumeLayout(false);
            this.guna2CustomGradientPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel16;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel30;
        public Guna.UI2.WinForms.Guna2DataGridView Bill;
        public Guna.UI2.WinForms.Guna2ComboBox cbForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button lblTotalAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
