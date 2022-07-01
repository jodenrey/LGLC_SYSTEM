namespace LGLC_SYSTEM
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Enrollment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.btnAddTeacher = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnroll = new System.Windows.Forms.ToolStripButton();
            this.btnBill = new System.Windows.Forms.ToolStripButton();
            this.btnSAccount = new System.Windows.Forms.ToolStripButton();
            this.tabMaintenance = new System.Windows.Forms.TabPage();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.btnUserSetting = new System.Windows.Forms.ToolStripButton();
            this.btnAddSecurity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddYear = new System.Windows.Forms.ToolStripButton();
            this.btnAddLvl = new System.Windows.Forms.ToolStripButton();
            this.btnAddSection = new System.Windows.Forms.ToolStripButton();
            this.btnFee = new System.Windows.Forms.ToolStripButton();
            this.btnAddRoom = new System.Windows.Forms.ToolStripButton();
            this.btnTime = new System.Windows.Forms.ToolStripButton();
            this.btnAddSubject = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnAboutUs = new System.Windows.Forms.ToolStripButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStudentList = new System.Windows.Forms.ToolStripButton();
            this.btnLogtrail = new System.Windows.Forms.ToolStripButton();
            this.btnAudit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportExecutionService1 = new Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.Enrollment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabMaintenance.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(976, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(227, 33);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "mm/dd/yy Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(150, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Little Garden Learning Center";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(169, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "508 Tanggerine St. Pecsonvile SJDM Bulacan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Enrollment);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 868);
            this.panel2.TabIndex = 15;
            // 
            // Enrollment
            // 
            this.Enrollment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Enrollment.Controls.Add(this.tabPage1);
            this.Enrollment.Controls.Add(this.tabMaintenance);
            this.Enrollment.Controls.Add(this.tabPage3);
            this.Enrollment.Controls.Add(this.tabPage4);
            this.Enrollment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollment.Location = new System.Drawing.Point(0, 0);
            this.Enrollment.Name = "Enrollment";
            this.Enrollment.SelectedIndex = 0;
            this.Enrollment.Size = new System.Drawing.Size(1386, 138);
            this.Enrollment.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1378, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaction";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnAddStudent,
            this.btnAddTeacher,
            this.toolStripSeparator3,
            this.btnEnroll,
            this.btnBill,
            this.btnSAccount});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(476, 96);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 96);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(76, 93);
            this.btnAddStudent.Text = "Student";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTeacher.Image")));
            this.btnAddTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(76, 93);
            this.btnAddTeacher.Text = "Teacher";
            this.btnAddTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 96);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnEnroll.Image")));
            this.btnEnroll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEnroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(76, 93);
            this.btnEnroll.Text = "Enrollment";
            this.btnEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(76, 93);
            this.btnBill.Text = "Bill";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnSAccount
            // 
            this.btnSAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSAccount.Image")));
            this.btnSAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSAccount.Name = "btnSAccount";
            this.btnSAccount.Size = new System.Drawing.Size(146, 93);
            this.btnSAccount.Text = "Statement of Account";
            this.btnSAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSAccount.Click += new System.EventHandler(this.btnSAccount_Click);
            // 
            // tabMaintenance
            // 
            this.tabMaintenance.Controls.Add(this.toolMain);
            this.tabMaintenance.Location = new System.Drawing.Point(4, 26);
            this.tabMaintenance.Name = "tabMaintenance";
            this.tabMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaintenance.Size = new System.Drawing.Size(1378, 108);
            this.tabMaintenance.TabIndex = 1;
            this.tabMaintenance.Text = "Maintenance";
            this.tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // toolMain
            // 
            this.toolMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolMain.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut,
            this.btnUserSetting,
            this.btnAddSecurity,
            this.toolStripSeparator5,
            this.btnAddYear,
            this.btnAddLvl,
            this.btnAddSection,
            this.btnFee,
            this.btnAddRoom,
            this.btnTime,
            this.btnAddSubject});
            this.toolMain.Location = new System.Drawing.Point(3, 3);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1372, 102);
            this.toolMain.TabIndex = 1;
            this.toolMain.Text = "toolStrip3";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogOut.ImageTransparentColor = System.Drawing.Color.White;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(90, 99);
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.ToolTipText = "LogOut";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSetting.Image")));
            this.btnUserSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUserSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(86, 99);
            this.btnUserSetting.Text = "User settings";
            this.btnUserSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // btnAddSecurity
            // 
            this.btnAddSecurity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSecurity.Image")));
            this.btnAddSecurity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSecurity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSecurity.Name = "btnAddSecurity";
            this.btnAddSecurity.Size = new System.Drawing.Size(76, 99);
            this.btnAddSecurity.Text = "Security";
            this.btnAddSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSecurity.Click += new System.EventHandler(this.btnAddSecurity_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 102);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.Image = ((System.Drawing.Image)(resources.GetObject("btnAddYear.Image")));
            this.btnAddYear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(83, 99);
            this.btnAddYear.Text = "School Year";
            this.btnAddYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnAddLvl
            // 
            this.btnAddLvl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLvl.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLvl.Image")));
            this.btnAddLvl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddLvl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLvl.Name = "btnAddLvl";
            this.btnAddLvl.Size = new System.Drawing.Size(83, 99);
            this.btnAddLvl.Text = "Grade level";
            this.btnAddLvl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddLvl.Click += new System.EventHandler(this.btnAddLvl_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSection.Image")));
            this.btnAddSection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(76, 99);
            this.btnAddSection.Text = "Section";
            this.btnAddSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnFee
            // 
            this.btnFee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.Image = ((System.Drawing.Image)(resources.GetObject("btnFee.Image")));
            this.btnFee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(76, 99);
            this.btnFee.Text = "Tution fee";
            this.btnFee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(76, 99);
            this.btnAddRoom.Text = "Room";
            this.btnAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Image = ((System.Drawing.Image)(resources.GetObject("btnTime.Image")));
            this.btnTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(96, 99);
            this.btnTime.Text = "Time schedule";
            this.btnTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.Image")));
            this.btnAddSubject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(76, 99);
            this.btnAddSubject.Text = "Subject";
            this.btnAddSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSubject.Visible = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip4);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1378, 108);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip4.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnView,
            this.btnAboutUs});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(1372, 102);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 102);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(76, 99);
            this.btnView.Text = "Enrollees";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(76, 99);
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.toolStrip5);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1378, 108);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip5
            // 
            this.toolStrip5.BackColor = System.Drawing.Color.White;
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip5.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.btnStudentList,
            this.btnLogtrail,
            this.btnAudit});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(1372, 102);
            this.toolStrip5.TabIndex = 2;
            this.toolStrip5.Text = "toolStrip5";
            this.toolStrip5.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip5_ItemClicked);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 102);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentList.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentList.Image")));
            this.btnStudentList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStudentList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(78, 99);
            this.btnStudentList.Text = "Student list";
            this.btnStudentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // btnLogtrail
            // 
            this.btnLogtrail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogtrail.Image = ((System.Drawing.Image)(resources.GetObject("btnLogtrail.Image")));
            this.btnLogtrail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogtrail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogtrail.Name = "btnLogtrail";
            this.btnLogtrail.Size = new System.Drawing.Size(76, 99);
            this.btnLogtrail.Text = "Log trail";
            this.btnLogtrail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogtrail.Click += new System.EventHandler(this.btnLogtrail_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudit.Image = ((System.Drawing.Image)(resources.GetObject("btnAudit.Image")));
            this.btnAudit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(76, 99);
            this.btnAudit.Text = "Audit trail";
            this.btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(978, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(1045, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 24);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::LGLC_SYSTEM.Properties.Resources.lglclogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportExecutionService1
            // 
            this.reportExecutionService1.Credentials = null;
            this.reportExecutionService1.ExecutionHeaderValue = null;
            this.reportExecutionService1.PrintControlClsidHeaderValue = null;
            this.reportExecutionService1.ServerInfoHeaderValue = null;
            this.reportExecutionService1.TrustedUserHeaderValue = null;
            this.reportExecutionService1.Url = "http://localhost/ReportServer/ReportExecution2005.asmx";
            this.reportExecutionService1.UseDefaultCredentials = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1354, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 16);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.ForeColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1328, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 16);
            this.btnMini.TabIndex = 20;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 800);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Frame";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.panel2.ResumeLayout(false);
            this.Enrollment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabMaintenance.ResumeLayout(false);
            this.tabMaintenance.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService reportExecutionService1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.TabControl Enrollment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddStudent;
        private System.Windows.Forms.ToolStripButton btnAddTeacher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEnroll;
        private System.Windows.Forms.ToolStripButton btnBill;
        private System.Windows.Forms.ToolStripButton btnSAccount;
        public System.Windows.Forms.TabPage tabMaintenance;
        public System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton btnUserSetting;
        public System.Windows.Forms.ToolStripButton btnAddSecurity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnAddYear;
        public System.Windows.Forms.ToolStripButton btnAddLvl;
        public System.Windows.Forms.ToolStripButton btnAddSection;
        public System.Windows.Forms.ToolStripButton btnFee;
        public System.Windows.Forms.ToolStripButton btnAddRoom;
        public System.Windows.Forms.ToolStripButton btnTime;
    
        public System.Windows.Forms.ToolStripButton btnAddSubject;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnAboutUs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnStudentList;
        public System.Windows.Forms.ToolStripButton btnLogtrail;
        public System.Windows.Forms.ToolStripButton btnAudit;
        public System.Windows.Forms.ToolStripButton btnLogOut;
    }
}