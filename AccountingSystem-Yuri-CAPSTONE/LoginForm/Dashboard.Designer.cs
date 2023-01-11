namespace LoginForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new Guna.UI2.WinForms.Guna2Button();
            this.min_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.applicationFormBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.analyticsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reportsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.min_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 52);
            this.panel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BorderRadius = 20;
            this.close_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Gray;
            this.close_btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.close_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(1250, 8);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(43, 34);
            this.close_btn.TabIndex = 8;
            this.close_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // min_btn
            // 
            this.min_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_btn.BorderRadius = 20;
            this.min_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.min_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.min_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.min_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.min_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.min_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_btn.ForeColor = System.Drawing.Color.Gray;
            this.min_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.min_btn.Image = ((System.Drawing.Image)(resources.GetObject("min_btn.Image")));
            this.min_btn.Location = new System.Drawing.Point(1201, 8);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(43, 34);
            this.min_btn.TabIndex = 7;
            this.min_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Work Smart, Not Hard";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(601, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to Upfront Workflow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upfront Workflow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.applicationFormBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Controls.Add(this.analyticsBtn);
            this.panel2.Controls.Add(this.reportsBtn);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 668);
            this.panel2.TabIndex = 1;
            // 
            // applicationFormBtn
            // 
            this.applicationFormBtn.BorderRadius = 20;
            this.applicationFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applicationFormBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applicationFormBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applicationFormBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applicationFormBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applicationFormBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.applicationFormBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationFormBtn.ForeColor = System.Drawing.Color.Gray;
            this.applicationFormBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.applicationFormBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.applicationFormBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.applicationFormBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.applicationFormBtn.Image = ((System.Drawing.Image)(resources.GetObject("applicationFormBtn.Image")));
            this.applicationFormBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.applicationFormBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.applicationFormBtn.Location = new System.Drawing.Point(-1, 254);
            this.applicationFormBtn.Name = "applicationFormBtn";
            this.applicationFormBtn.Size = new System.Drawing.Size(180, 45);
            this.applicationFormBtn.TabIndex = 8;
            this.applicationFormBtn.Text = "Application Forms";
            this.applicationFormBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.applicationFormBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.applicationFormBtn.Click += new System.EventHandler(this.applicationFormBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 151);
            this.panel4.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(49, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Username";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(52, 9);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BorderRadius = 20;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.settingsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.Gray;
            this.settingsBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.settingsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.settingsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.settingsBtn.Location = new System.Drawing.Point(0, 356);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(180, 45);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // analyticsBtn
            // 
            this.analyticsBtn.BorderRadius = 20;
            this.analyticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyticsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.analyticsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.analyticsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.analyticsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.analyticsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.analyticsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyticsBtn.ForeColor = System.Drawing.Color.Gray;
            this.analyticsBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.analyticsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.analyticsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.analyticsBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.analyticsBtn.Image = ((System.Drawing.Image)(resources.GetObject("analyticsBtn.Image")));
            this.analyticsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.analyticsBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.analyticsBtn.Location = new System.Drawing.Point(0, 305);
            this.analyticsBtn.Name = "analyticsBtn";
            this.analyticsBtn.Size = new System.Drawing.Size(180, 45);
            this.analyticsBtn.TabIndex = 5;
            this.analyticsBtn.Text = "Statistics";
            this.analyticsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.analyticsBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BorderRadius = 20;
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.reportsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.Gray;
            this.reportsBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.reportsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.reportsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.reportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Image")));
            this.reportsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.reportsBtn.Location = new System.Drawing.Point(0, 208);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(180, 45);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BorderRadius = 20;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Gray;
            this.logoutBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.logoutBtn.Location = new System.Drawing.Point(0, 409);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(180, 45);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BorderRadius = 20;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Gray;
            this.dashboardBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.dashboardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.dashboardBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.dashboardBtn.Location = new System.Drawing.Point(0, 157);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(180, 45);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainpanel.Location = new System.Drawing.Point(186, 52);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1114, 684);
            this.mainpanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(127)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Button analyticsBtn;
        private Guna.UI2.WinForms.Guna2Button reportsBtn;
        private System.Windows.Forms.Panel mainpanel;
        private Guna.UI2.WinForms.Guna2Button close_btn;
        private Guna.UI2.WinForms.Guna2Button min_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button applicationFormBtn;
    }
}