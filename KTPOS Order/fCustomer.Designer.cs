namespace KTPOS_Order
{
    partial class fCustomer
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
            this.btnMinSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaxSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoodOptions = new Guna.UI2.WinForms.Guna2Button();
            this.btnDrinks = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnChat = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel16 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2HtmlLabel30 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FlowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel16.SuspendLayout();
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
            btnClose.Location = new System.Drawing.Point(1350, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(25, 25);
            btnClose.TabIndex = 8;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnMinSize.Location = new System.Drawing.Point(1308, 25);
            this.btnMinSize.Name = "btnMinSize";
            this.btnMinSize.Size = new System.Drawing.Size(25, 25);
            this.btnMinSize.TabIndex = 19;
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
            this.btnMaxSize.Location = new System.Drawing.Point(1308, 25);
            this.btnMaxSize.Name = "btnMaxSize";
            this.btnMaxSize.Size = new System.Drawing.Size(25, 25);
            this.btnMaxSize.TabIndex = 20;
            this.btnMaxSize.Click += new System.EventHandler(this.btnMaxSize_Click);
            // 
            // btnFoodOrder
            // 
            this.btnFoodOrder.Animated = true;
            this.btnFoodOrder.AutoRoundedCorners = true;
            this.btnFoodOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodOrder.BorderRadius = 25;
            this.btnFoodOrder.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnFoodOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFoodOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnFoodOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFoodOrder.ForeColor = System.Drawing.Color.White;
            this.btnFoodOrder.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFoodOrder.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFoodOrder.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFoodOrder.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnFoodOrder.Location = new System.Drawing.Point(12, 12);
            this.btnFoodOrder.Name = "btnFoodOrder";
            this.btnFoodOrder.Size = new System.Drawing.Size(106, 52);
            this.btnFoodOrder.TabIndex = 21;
            this.btnFoodOrder.Text = "All Items";
            this.btnFoodOrder.Click += new System.EventHandler(this.btnFoodOrder_Click);
            // 
            // btnFoodOptions
            // 
            this.btnFoodOptions.Animated = true;
            this.btnFoodOptions.AutoRoundedCorners = true;
            this.btnFoodOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodOptions.BorderRadius = 25;
            this.btnFoodOptions.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnFoodOptions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFoodOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodOptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodOptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodOptions.FillColor = System.Drawing.Color.Transparent;
            this.btnFoodOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFoodOptions.ForeColor = System.Drawing.Color.White;
            this.btnFoodOptions.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFoodOptions.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFoodOptions.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFoodOptions.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnFoodOptions.Location = new System.Drawing.Point(141, 12);
            this.btnFoodOptions.Name = "btnFoodOptions";
            this.btnFoodOptions.Size = new System.Drawing.Size(250, 52);
            this.btnFoodOptions.TabIndex = 22;
            this.btnFoodOptions.Text = "Hamburger and others";
            this.btnFoodOptions.Click += new System.EventHandler(this.btnFoodOptions_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Animated = true;
            this.btnDrinks.AutoRoundedCorners = true;
            this.btnDrinks.BackColor = System.Drawing.Color.Transparent;
            this.btnDrinks.BorderRadius = 25;
            this.btnDrinks.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnDrinks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrinks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrinks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrinks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrinks.FillColor = System.Drawing.Color.Transparent;
            this.btnDrinks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDrinks.ForeColor = System.Drawing.Color.White;
            this.btnDrinks.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDrinks.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDrinks.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDrinks.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnDrinks.Location = new System.Drawing.Point(382, 12);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(105, 52);
            this.btnDrinks.TabIndex = 23;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseTransparentBackground = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 25;
            this.btnPay.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnPay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPay.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnPay.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPay.HoverState.ForeColor = System.Drawing.Color.Maroon;
            this.btnPay.Location = new System.Drawing.Point(502, 12);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(142, 52);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "Payment";
            this.btnPay.UseTransparentBackground = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.btnChat.Location = new System.Drawing.Point(662, 12);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(102, 52);
            this.btnChat.TabIndex = 25;
            this.btnChat.Text = "Chat";
            this.btnChat.UseTransparentBackground = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.AutoSize = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::KTPOS_Order.Properties.Resources.magnifying_glass_solid;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.txtSearch.Location = new System.Drawing.Point(1071, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MaximumSize = new System.Drawing.Size(240, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(210, 38);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2CustomGradientPanel16
            // 
            this.guna2CustomGradientPanel16.AutoSize = true;
            this.guna2CustomGradientPanel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel16.BackgroundImage = global::KTPOS_Order.Properties.Resources._26df8325fe115cf3f8c0fd7a99c74108;
            this.guna2CustomGradientPanel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CustomGradientPanel16.BorderColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.BorderRadius = 15;
            this.guna2CustomGradientPanel16.Controls.Add(this.btnOrder);
            this.guna2CustomGradientPanel16.Controls.Add(this.txtTotal);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel16.Controls.Add(this.listView);
            this.guna2CustomGradientPanel16.Controls.Add(this.guna2HtmlLabel30);
            this.guna2CustomGradientPanel16.FillColor = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor3 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.FillColor4 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel16.Location = new System.Drawing.Point(52, 137);
            this.guna2CustomGradientPanel16.Name = "guna2CustomGradientPanel16";
            this.guna2CustomGradientPanel16.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.guna2CustomGradientPanel16.Size = new System.Drawing.Size(391, 501);
            this.guna2CustomGradientPanel16.TabIndex = 34;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = false;
            this.txtTotal.BackColor = System.Drawing.Color.Maroon;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(206, 379);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(155, 33);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "H";
            this.txtTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(68, 379);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(59, 32);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Total:";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
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
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
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
            // FlowMenu
            // 
            this.FlowMenu.AutoScroll = true;
            this.FlowMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowMenu.BackColor = System.Drawing.Color.Transparent;
            this.FlowMenu.Location = new System.Drawing.Point(473, 137);
            this.FlowMenu.Name = "FlowMenu";
            this.FlowMenu.Size = new System.Drawing.Size(839, 501);
            this.FlowMenu.TabIndex = 36;
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
            this.Filter.Location = new System.Drawing.Point(1089, 95);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(211, 36);
            this.Filter.TabIndex = 35;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrder.Animated = true;
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderRadius = 30;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnOrder.Location = new System.Drawing.Point(89, 418);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(213, 62);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseTransparentBackground = true;
            this.btnOrder.Click += new System.EventHandler(this.guna2Button15_Click);
            // 
            // fCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::KTPOS_Order.Properties.Resources.shutterstock_1088296091;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 740);
            this.Controls.Add(this.FlowMenu);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.guna2CustomGradientPanel16);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnFoodOptions);
            this.Controls.Add(this.btnFoodOrder);
            this.Controls.Add(this.btnMaxSize);
            this.Controls.Add(this.btnMinSize);
            this.Controls.Add(btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.guna2CustomGradientPanel16.ResumeLayout(false);
            this.guna2CustomGradientPanel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btnMinSize;
        public Guna.UI2.WinForms.Guna2Button btnMaxSize;
        public Guna.UI2.WinForms.Guna2Button btnFoodOrder;
        public Guna.UI2.WinForms.Guna2Button btnFoodOptions;
        public Guna.UI2.WinForms.Guna2Button btnDrinks;
        public Guna.UI2.WinForms.Guna2Button btnPay;
        public Guna.UI2.WinForms.Guna2Button btnChat;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel16;
        public Guna.UI2.WinForms.Guna2HtmlLabel txtTotal;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public System.Windows.Forms.ListView listView;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel30;
        public System.Windows.Forms.FlowLayoutPanel FlowMenu;
        public Guna.UI2.WinForms.Guna2ComboBox Filter;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
    }
}