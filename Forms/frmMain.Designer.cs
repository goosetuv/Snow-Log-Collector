namespace SLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSLM = new System.Windows.Forms.TabPage();
            this.gbSLMServices = new System.Windows.Forms.GroupBox();
            this.btnSLMServicesLogsCustom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSLMServicesLogs = new System.Windows.Forms.Button();
            this.gbSLMWebLogs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWebLogs = new System.Windows.Forms.Button();
            this.gbDUJ = new System.Windows.Forms.GroupBox();
            this.lblDUJNotice = new System.Windows.Forms.Label();
            this.btnDUJ = new System.Windows.Forms.Button();
            this.tabINV = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gbGeneralPreferences = new System.Windows.Forms.GroupBox();
            this.btnGeneralSaveDirectory = new System.Windows.Forms.Button();
            this.lblReportingTableDesign = new System.Windows.Forms.Label();
            this.cblReportingTableDesign = new System.Windows.Forms.ComboBox();
            this.txtGeneralSaveDirectory = new System.Windows.Forms.TextBox();
            this.lblGeneralSaveDirectory = new System.Windows.Forms.Label();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.gbSnowApplications = new System.Windows.Forms.GroupBox();
            this.txtINVDrive = new System.Windows.Forms.TextBox();
            this.lblINVDrive = new System.Windows.Forms.Label();
            this.txtINVServer = new System.Windows.Forms.TextBox();
            this.lblINVServer = new System.Windows.Forms.Label();
            this.txtSLMDrive = new System.Windows.Forms.TextBox();
            this.lblSLMDrive = new System.Windows.Forms.Label();
            this.txtSLMServer = new System.Windows.Forms.TextBox();
            this.lblSLMServer = new System.Windows.Forms.Label();
            this.dbSqlServer = new System.Windows.Forms.GroupBox();
            this.lblSqlServerParameters = new System.Windows.Forms.Label();
            this.txtSqlServerParameters = new System.Windows.Forms.TextBox();
            this.btnSqlServerTest = new System.Windows.Forms.Button();
            this.cbSqlServerWindowsAuth = new System.Windows.Forms.CheckBox();
            this.lblSqlServerPassword = new System.Windows.Forms.Label();
            this.txtSqlServerPassword = new System.Windows.Forms.TextBox();
            this.lblSqlServerUsername = new System.Windows.Forms.Label();
            this.txtSqlServerUsername = new System.Windows.Forms.TextBox();
            this.txtSqlServerName = new System.Windows.Forms.TextBox();
            this.lblSqlServerName = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsLblCollectorStatus = new System.Windows.Forms.ToolStripLabel();
            this.tsLblCollectorStatusValue = new System.Windows.Forms.ToolStripLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControlMain.SuspendLayout();
            this.tabSLM.SuspendLayout();
            this.gbSLMServices.SuspendLayout();
            this.gbSLMWebLogs.SuspendLayout();
            this.gbDUJ.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbGeneralPreferences.SuspendLayout();
            this.gbSnowApplications.SuspendLayout();
            this.dbSqlServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlMain.Controls.Add(this.tabSLM);
            this.tabControlMain.Controls.Add(this.tabINV);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Location = new System.Drawing.Point(0, 120);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(472, 275);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabSLM
            // 
            this.tabSLM.Controls.Add(this.gbSLMServices);
            this.tabSLM.Controls.Add(this.gbSLMWebLogs);
            this.tabSLM.Controls.Add(this.gbDUJ);
            this.tabSLM.Location = new System.Drawing.Point(4, 22);
            this.tabSLM.Name = "tabSLM";
            this.tabSLM.Padding = new System.Windows.Forms.Padding(3);
            this.tabSLM.Size = new System.Drawing.Size(464, 249);
            this.tabSLM.TabIndex = 0;
            this.tabSLM.Text = "Snow License Manager";
            this.tabSLM.UseVisualStyleBackColor = true;
            // 
            // gbSLMServices
            // 
            this.gbSLMServices.Controls.Add(this.btnSLMServicesLogsCustom);
            this.gbSLMServices.Controls.Add(this.label2);
            this.gbSLMServices.Controls.Add(this.btnSLMServicesLogs);
            this.gbSLMServices.Location = new System.Drawing.Point(10, 135);
            this.gbSLMServices.Name = "gbSLMServices";
            this.gbSLMServices.Size = new System.Drawing.Size(200, 100);
            this.gbSLMServices.TabIndex = 3;
            this.gbSLMServices.TabStop = false;
            this.gbSLMServices.Text = "License Manager Services Logs";
            // 
            // btnSLMServicesLogsCustom
            // 
            this.btnSLMServicesLogsCustom.Location = new System.Drawing.Point(10, 65);
            this.btnSLMServicesLogsCustom.Name = "btnSLMServicesLogsCustom";
            this.btnSLMServicesLogsCustom.Size = new System.Drawing.Size(75, 23);
            this.btnSLMServicesLogsCustom.TabIndex = 2;
            this.btnSLMServicesLogsCustom.Text = "Custom Get";
            this.btnSLMServicesLogsCustom.UseVisualStyleBackColor = true;
            this.btnSLMServicesLogsCustom.Click += new System.EventHandler(this.btnSLMServicesLogsCustom_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compatiable with Snow License Manager 7.x, 8.x and 9.x.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSLMServicesLogs
            // 
            this.btnSLMServicesLogs.Location = new System.Drawing.Point(115, 65);
            this.btnSLMServicesLogs.Name = "btnSLMServicesLogs";
            this.btnSLMServicesLogs.Size = new System.Drawing.Size(75, 23);
            this.btnSLMServicesLogs.TabIndex = 0;
            this.btnSLMServicesLogs.Text = "Get All";
            this.btnSLMServicesLogs.UseVisualStyleBackColor = true;
            this.btnSLMServicesLogs.Click += new System.EventHandler(this.btnSLMServicesLogs_Click);
            // 
            // gbSLMWebLogs
            // 
            this.gbSLMWebLogs.Controls.Add(this.label1);
            this.gbSLMWebLogs.Controls.Add(this.btnWebLogs);
            this.gbSLMWebLogs.Location = new System.Drawing.Point(252, 10);
            this.gbSLMWebLogs.Name = "gbSLMWebLogs";
            this.gbSLMWebLogs.Size = new System.Drawing.Size(200, 100);
            this.gbSLMWebLogs.TabIndex = 2;
            this.gbSLMWebLogs.TabStop = false;
            this.gbSLMWebLogs.Text = "Web Logs";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compatiable with Snow License Manager 7.x, 8.x and 9.x.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWebLogs
            // 
            this.btnWebLogs.Location = new System.Drawing.Point(115, 65);
            this.btnWebLogs.Name = "btnWebLogs";
            this.btnWebLogs.Size = new System.Drawing.Size(75, 23);
            this.btnWebLogs.TabIndex = 0;
            this.btnWebLogs.Text = "Get All";
            this.btnWebLogs.UseVisualStyleBackColor = true;
            this.btnWebLogs.Click += new System.EventHandler(this.btnWebLogs_Click);
            // 
            // gbDUJ
            // 
            this.gbDUJ.Controls.Add(this.lblDUJNotice);
            this.gbDUJ.Controls.Add(this.btnDUJ);
            this.gbDUJ.Location = new System.Drawing.Point(10, 10);
            this.gbDUJ.Name = "gbDUJ";
            this.gbDUJ.Size = new System.Drawing.Size(200, 100);
            this.gbDUJ.TabIndex = 0;
            this.gbDUJ.TabStop = false;
            this.gbDUJ.Text = "Data Update Job";
            // 
            // lblDUJNotice
            // 
            this.lblDUJNotice.AutoEllipsis = true;
            this.lblDUJNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDUJNotice.Location = new System.Drawing.Point(10, 20);
            this.lblDUJNotice.Name = "lblDUJNotice";
            this.lblDUJNotice.Size = new System.Drawing.Size(180, 42);
            this.lblDUJNotice.TabIndex = 1;
            this.lblDUJNotice.Text = "Compatiable with Snow License Manager 7.x, 8.x and 9.x.";
            this.lblDUJNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDUJ
            // 
            this.btnDUJ.Location = new System.Drawing.Point(115, 65);
            this.btnDUJ.Name = "btnDUJ";
            this.btnDUJ.Size = new System.Drawing.Size(75, 23);
            this.btnDUJ.TabIndex = 0;
            this.btnDUJ.Text = "Export";
            this.btnDUJ.UseVisualStyleBackColor = true;
            this.btnDUJ.Click += new System.EventHandler(this.btnDUJ_Click);
            // 
            // tabINV
            // 
            this.tabINV.Location = new System.Drawing.Point(4, 22);
            this.tabINV.Name = "tabINV";
            this.tabINV.Padding = new System.Windows.Forms.Padding(3);
            this.tabINV.Size = new System.Drawing.Size(464, 249);
            this.tabINV.TabIndex = 1;
            this.tabINV.Text = "Snow Inventory";
            this.tabINV.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.AutoScroll = true;
            this.tabSettings.Controls.Add(this.gbGeneralPreferences);
            this.tabSettings.Controls.Add(this.btnSettingsSave);
            this.tabSettings.Controls.Add(this.gbSnowApplications);
            this.tabSettings.Controls.Add(this.dbSqlServer);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(464, 249);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gbGeneralPreferences
            // 
            this.gbGeneralPreferences.Controls.Add(this.btnGeneralSaveDirectory);
            this.gbGeneralPreferences.Controls.Add(this.lblReportingTableDesign);
            this.gbGeneralPreferences.Controls.Add(this.cblReportingTableDesign);
            this.gbGeneralPreferences.Controls.Add(this.txtGeneralSaveDirectory);
            this.gbGeneralPreferences.Controls.Add(this.lblGeneralSaveDirectory);
            this.gbGeneralPreferences.Location = new System.Drawing.Point(10, 311);
            this.gbGeneralPreferences.Name = "gbGeneralPreferences";
            this.gbGeneralPreferences.Size = new System.Drawing.Size(428, 79);
            this.gbGeneralPreferences.TabIndex = 8;
            this.gbGeneralPreferences.TabStop = false;
            this.gbGeneralPreferences.Text = "General Preferences";
            // 
            // btnGeneralSaveDirectory
            // 
            this.btnGeneralSaveDirectory.Location = new System.Drawing.Point(379, 15);
            this.btnGeneralSaveDirectory.Name = "btnGeneralSaveDirectory";
            this.btnGeneralSaveDirectory.Size = new System.Drawing.Size(39, 23);
            this.btnGeneralSaveDirectory.TabIndex = 5;
            this.btnGeneralSaveDirectory.Text = "...";
            this.btnGeneralSaveDirectory.UseVisualStyleBackColor = true;
            this.btnGeneralSaveDirectory.Click += new System.EventHandler(this.btnGeneralSaveDirectory_Click);
            // 
            // lblReportingTableDesign
            // 
            this.lblReportingTableDesign.AutoSize = true;
            this.lblReportingTableDesign.Location = new System.Drawing.Point(60, 46);
            this.lblReportingTableDesign.Name = "lblReportingTableDesign";
            this.lblReportingTableDesign.Size = new System.Drawing.Size(106, 13);
            this.lblReportingTableDesign.TabIndex = 4;
            this.lblReportingTableDesign.Text = "Export Table Design:";
            // 
            // cblReportingTableDesign
            // 
            this.cblReportingTableDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblReportingTableDesign.FormattingEnabled = true;
            this.cblReportingTableDesign.Items.AddRange(new object[] {
            "None",
            "Light1",
            "Light2",
            "Light3",
            "Light4",
            "Light5",
            "Light6",
            "Light7",
            "Light8",
            "Light9",
            "Light10",
            "Light11",
            "Light12",
            "Light13",
            "Light14",
            "Light15",
            "Light16",
            "Light17",
            "Light18",
            "Light19",
            "Light20",
            "Light21",
            "Medium1",
            "Medium2",
            "Medium3",
            "Medium4",
            "Medium5",
            "Medium6",
            "Medium7",
            "Medium8",
            "Medium9",
            "Medium10",
            "Medium11",
            "Medium12",
            "Medium13",
            "Medium14",
            "Medium15",
            "Medium16",
            "Medium17",
            "Medium18",
            "Medium19",
            "Medium20",
            "Medium21",
            "Medium22",
            "Medium23",
            "Medium24",
            "Medium25",
            "Medium26",
            "Medium27",
            "Medium28",
            "Dark1",
            "Dark2",
            "Dark3",
            "Dark4",
            "Dark5",
            "Dark6",
            "Dark7",
            "Dark8",
            "Dark9",
            "Dark10",
            "Dark11"});
            this.cblReportingTableDesign.Location = new System.Drawing.Point(172, 43);
            this.cblReportingTableDesign.MaxDropDownItems = 50;
            this.cblReportingTableDesign.Name = "cblReportingTableDesign";
            this.cblReportingTableDesign.Size = new System.Drawing.Size(246, 21);
            this.cblReportingTableDesign.TabIndex = 3;
            // 
            // txtGeneralSaveDirectory
            // 
            this.txtGeneralSaveDirectory.Location = new System.Drawing.Point(172, 17);
            this.txtGeneralSaveDirectory.Name = "txtGeneralSaveDirectory";
            this.txtGeneralSaveDirectory.Size = new System.Drawing.Size(201, 20);
            this.txtGeneralSaveDirectory.TabIndex = 1;
            // 
            // lblGeneralSaveDirectory
            // 
            this.lblGeneralSaveDirectory.AutoSize = true;
            this.lblGeneralSaveDirectory.Location = new System.Drawing.Point(86, 20);
            this.lblGeneralSaveDirectory.Name = "lblGeneralSaveDirectory";
            this.lblGeneralSaveDirectory.Size = new System.Drawing.Size(80, 13);
            this.lblGeneralSaveDirectory.TabIndex = 0;
            this.lblGeneralSaveDirectory.Text = "Save Directory:";
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Location = new System.Drawing.Point(350, 396);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(88, 23);
            this.btnSettingsSave.TabIndex = 2;
            this.btnSettingsSave.Text = "Save Settings";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // gbSnowApplications
            // 
            this.gbSnowApplications.Controls.Add(this.txtINVDrive);
            this.gbSnowApplications.Controls.Add(this.lblINVDrive);
            this.gbSnowApplications.Controls.Add(this.txtINVServer);
            this.gbSnowApplications.Controls.Add(this.lblINVServer);
            this.gbSnowApplications.Controls.Add(this.txtSLMDrive);
            this.gbSnowApplications.Controls.Add(this.lblSLMDrive);
            this.gbSnowApplications.Controls.Add(this.txtSLMServer);
            this.gbSnowApplications.Controls.Add(this.lblSLMServer);
            this.gbSnowApplications.Location = new System.Drawing.Point(10, 173);
            this.gbSnowApplications.Name = "gbSnowApplications";
            this.gbSnowApplications.Size = new System.Drawing.Size(428, 132);
            this.gbSnowApplications.TabIndex = 1;
            this.gbSnowApplications.TabStop = false;
            this.gbSnowApplications.Text = "Snow Software Applications";
            // 
            // txtINVDrive
            // 
            this.txtINVDrive.Location = new System.Drawing.Point(172, 95);
            this.txtINVDrive.Name = "txtINVDrive";
            this.txtINVDrive.Size = new System.Drawing.Size(246, 20);
            this.txtINVDrive.TabIndex = 7;
            // 
            // lblINVDrive
            // 
            this.lblINVDrive.AutoSize = true;
            this.lblINVDrive.Location = new System.Drawing.Point(54, 98);
            this.lblINVDrive.Name = "lblINVDrive";
            this.lblINVDrive.Size = new System.Drawing.Size(112, 13);
            this.lblINVDrive.TabIndex = 6;
            this.lblINVDrive.Text = "Snow Inventory Drive:";
            // 
            // txtINVServer
            // 
            this.txtINVServer.Location = new System.Drawing.Point(172, 69);
            this.txtINVServer.Name = "txtINVServer";
            this.txtINVServer.Size = new System.Drawing.Size(246, 20);
            this.txtINVServer.TabIndex = 5;
            // 
            // lblINVServer
            // 
            this.lblINVServer.AutoSize = true;
            this.lblINVServer.Location = new System.Drawing.Point(48, 72);
            this.lblINVServer.Name = "lblINVServer";
            this.lblINVServer.Size = new System.Drawing.Size(118, 13);
            this.lblINVServer.TabIndex = 4;
            this.lblINVServer.Text = "Snow Inventory Server:";
            // 
            // txtSLMDrive
            // 
            this.txtSLMDrive.Location = new System.Drawing.Point(172, 43);
            this.txtSLMDrive.Name = "txtSLMDrive";
            this.txtSLMDrive.Size = new System.Drawing.Size(246, 20);
            this.txtSLMDrive.TabIndex = 3;
            // 
            // lblSLMDrive
            // 
            this.lblSLMDrive.AutoSize = true;
            this.lblSLMDrive.Location = new System.Drawing.Point(16, 46);
            this.lblSLMDrive.Name = "lblSLMDrive";
            this.lblSLMDrive.Size = new System.Drawing.Size(150, 13);
            this.lblSLMDrive.TabIndex = 2;
            this.lblSLMDrive.Text = "Snow License Manager Drive:";
            // 
            // txtSLMServer
            // 
            this.txtSLMServer.Location = new System.Drawing.Point(172, 17);
            this.txtSLMServer.Name = "txtSLMServer";
            this.txtSLMServer.Size = new System.Drawing.Size(246, 20);
            this.txtSLMServer.TabIndex = 1;
            // 
            // lblSLMServer
            // 
            this.lblSLMServer.AutoSize = true;
            this.lblSLMServer.Location = new System.Drawing.Point(10, 20);
            this.lblSLMServer.Name = "lblSLMServer";
            this.lblSLMServer.Size = new System.Drawing.Size(156, 13);
            this.lblSLMServer.TabIndex = 0;
            this.lblSLMServer.Text = "Snow License Manager Server:";
            // 
            // dbSqlServer
            // 
            this.dbSqlServer.Controls.Add(this.lblSqlServerParameters);
            this.dbSqlServer.Controls.Add(this.txtSqlServerParameters);
            this.dbSqlServer.Controls.Add(this.btnSqlServerTest);
            this.dbSqlServer.Controls.Add(this.cbSqlServerWindowsAuth);
            this.dbSqlServer.Controls.Add(this.lblSqlServerPassword);
            this.dbSqlServer.Controls.Add(this.txtSqlServerPassword);
            this.dbSqlServer.Controls.Add(this.lblSqlServerUsername);
            this.dbSqlServer.Controls.Add(this.txtSqlServerUsername);
            this.dbSqlServer.Controls.Add(this.txtSqlServerName);
            this.dbSqlServer.Controls.Add(this.lblSqlServerName);
            this.dbSqlServer.Location = new System.Drawing.Point(10, 10);
            this.dbSqlServer.Name = "dbSqlServer";
            this.dbSqlServer.Size = new System.Drawing.Size(428, 157);
            this.dbSqlServer.TabIndex = 0;
            this.dbSqlServer.TabStop = false;
            this.dbSqlServer.Text = "SQL Server";
            // 
            // lblSqlServerParameters
            // 
            this.lblSqlServerParameters.AutoSize = true;
            this.lblSqlServerParameters.Location = new System.Drawing.Point(54, 98);
            this.lblSqlServerParameters.Name = "lblSqlServerParameters";
            this.lblSqlServerParameters.Size = new System.Drawing.Size(112, 13);
            this.lblSqlServerParameters.TabIndex = 16;
            this.lblSqlServerParameters.Text = "Additional Parameters:";
            // 
            // txtSqlServerParameters
            // 
            this.txtSqlServerParameters.Location = new System.Drawing.Point(172, 95);
            this.txtSqlServerParameters.Name = "txtSqlServerParameters";
            this.txtSqlServerParameters.Size = new System.Drawing.Size(246, 20);
            this.txtSqlServerParameters.TabIndex = 15;
            // 
            // btnSqlServerTest
            // 
            this.btnSqlServerTest.Location = new System.Drawing.Point(343, 121);
            this.btnSqlServerTest.Name = "btnSqlServerTest";
            this.btnSqlServerTest.Size = new System.Drawing.Size(75, 23);
            this.btnSqlServerTest.TabIndex = 14;
            this.btnSqlServerTest.Text = "Test";
            this.btnSqlServerTest.UseVisualStyleBackColor = true;
            this.btnSqlServerTest.Click += new System.EventHandler(this.btnSqlServerTest_Click);
            // 
            // cbSqlServerWindowsAuth
            // 
            this.cbSqlServerWindowsAuth.AutoSize = true;
            this.cbSqlServerWindowsAuth.Location = new System.Drawing.Point(172, 125);
            this.cbSqlServerWindowsAuth.Name = "cbSqlServerWindowsAuth";
            this.cbSqlServerWindowsAuth.Size = new System.Drawing.Size(141, 17);
            this.cbSqlServerWindowsAuth.TabIndex = 13;
            this.cbSqlServerWindowsAuth.Text = "Windows Authentication";
            this.cbSqlServerWindowsAuth.UseVisualStyleBackColor = true;
            this.cbSqlServerWindowsAuth.CheckedChanged += new System.EventHandler(this.cbSqlServerWindowsAuth_CheckedChanged);
            // 
            // lblSqlServerPassword
            // 
            this.lblSqlServerPassword.AutoSize = true;
            this.lblSqlServerPassword.Location = new System.Drawing.Point(52, 72);
            this.lblSqlServerPassword.Name = "lblSqlServerPassword";
            this.lblSqlServerPassword.Size = new System.Drawing.Size(114, 13);
            this.lblSqlServerPassword.TabIndex = 12;
            this.lblSqlServerPassword.Text = "SQL Server Password:";
            // 
            // txtSqlServerPassword
            // 
            this.txtSqlServerPassword.Location = new System.Drawing.Point(172, 69);
            this.txtSqlServerPassword.Name = "txtSqlServerPassword";
            this.txtSqlServerPassword.PasswordChar = '*';
            this.txtSqlServerPassword.Size = new System.Drawing.Size(246, 20);
            this.txtSqlServerPassword.TabIndex = 11;
            // 
            // lblSqlServerUsername
            // 
            this.lblSqlServerUsername.AutoSize = true;
            this.lblSqlServerUsername.Location = new System.Drawing.Point(50, 46);
            this.lblSqlServerUsername.Name = "lblSqlServerUsername";
            this.lblSqlServerUsername.Size = new System.Drawing.Size(116, 13);
            this.lblSqlServerUsername.TabIndex = 10;
            this.lblSqlServerUsername.Text = "SQL Server Username:";
            // 
            // txtSqlServerUsername
            // 
            this.txtSqlServerUsername.Location = new System.Drawing.Point(172, 43);
            this.txtSqlServerUsername.Name = "txtSqlServerUsername";
            this.txtSqlServerUsername.Size = new System.Drawing.Size(246, 20);
            this.txtSqlServerUsername.TabIndex = 9;
            // 
            // txtSqlServerName
            // 
            this.txtSqlServerName.Location = new System.Drawing.Point(172, 17);
            this.txtSqlServerName.Name = "txtSqlServerName";
            this.txtSqlServerName.Size = new System.Drawing.Size(246, 20);
            this.txtSqlServerName.TabIndex = 8;
            // 
            // lblSqlServerName
            // 
            this.lblSqlServerName.AutoSize = true;
            this.lblSqlServerName.Location = new System.Drawing.Point(70, 20);
            this.lblSqlServerName.Name = "lblSqlServerName";
            this.lblSqlServerName.Size = new System.Drawing.Size(96, 13);
            this.lblSqlServerName.TabIndex = 1;
            this.lblSqlServerName.Text = "SQL Server Name:";
            // 
            // tabAbout
            // 
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(464, 249);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Image = global::SLC.Properties.Resources.slc_logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(472, 120);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblCollectorStatus,
            this.tsLblCollectorStatusValue});
            this.toolStripMain.Location = new System.Drawing.Point(0, 398);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(472, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsLblCollectorStatus
            // 
            this.tsLblCollectorStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLblCollectorStatus.Name = "tsLblCollectorStatus";
            this.tsLblCollectorStatus.Size = new System.Drawing.Size(98, 22);
            this.tsLblCollectorStatus.Text = "Collector Status:";
            // 
            // tsLblCollectorStatusValue
            // 
            this.tsLblCollectorStatusValue.Name = "tsLblCollectorStatusValue";
            this.tsLblCollectorStatusValue.Size = new System.Drawing.Size(57, 22);
            this.tsLblCollectorStatusValue.Text = "Waiting...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(413, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Log Collector";
            this.tabControlMain.ResumeLayout(false);
            this.tabSLM.ResumeLayout(false);
            this.gbSLMServices.ResumeLayout(false);
            this.gbSLMWebLogs.ResumeLayout(false);
            this.gbDUJ.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.gbGeneralPreferences.ResumeLayout(false);
            this.gbGeneralPreferences.PerformLayout();
            this.gbSnowApplications.ResumeLayout(false);
            this.gbSnowApplications.PerformLayout();
            this.dbSqlServer.ResumeLayout(false);
            this.dbSqlServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSLM;
        private System.Windows.Forms.TabPage tabINV;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox gbDUJ;
        private System.Windows.Forms.Button btnDUJ;
        private System.Windows.Forms.Label lblDUJNotice;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripLabel tsLblCollectorStatus;
        private System.Windows.Forms.ToolStripLabel tsLblCollectorStatusValue;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox dbSqlServer;
        private System.Windows.Forms.GroupBox gbSnowApplications;
        private System.Windows.Forms.Label lblSLMServer;
        private System.Windows.Forms.TextBox txtSLMServer;
        private System.Windows.Forms.TextBox txtINVServer;
        private System.Windows.Forms.Label lblINVServer;
        private System.Windows.Forms.TextBox txtSLMDrive;
        private System.Windows.Forms.Label lblSLMDrive;
        private System.Windows.Forms.TextBox txtINVDrive;
        private System.Windows.Forms.Label lblINVDrive;
        private System.Windows.Forms.TextBox txtSqlServerName;
        private System.Windows.Forms.Label lblSqlServerName;
        private System.Windows.Forms.Label lblSqlServerUsername;
        private System.Windows.Forms.TextBox txtSqlServerUsername;
        private System.Windows.Forms.Label lblSqlServerPassword;
        private System.Windows.Forms.TextBox txtSqlServerPassword;
        private System.Windows.Forms.CheckBox cbSqlServerWindowsAuth;
        private System.Windows.Forms.Button btnSqlServerTest;
        private System.Windows.Forms.TextBox txtSqlServerParameters;
        private System.Windows.Forms.Label lblSqlServerParameters;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.GroupBox gbGeneralPreferences;
        private System.Windows.Forms.TextBox txtGeneralSaveDirectory;
        private System.Windows.Forms.Label lblGeneralSaveDirectory;
        private System.Windows.Forms.Label lblReportingTableDesign;
        private System.Windows.Forms.ComboBox cblReportingTableDesign;
        private System.Windows.Forms.GroupBox gbSLMWebLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWebLogs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbSLMServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSLMServicesLogs;
        private System.Windows.Forms.Button btnSLMServicesLogsCustom;
        private System.Windows.Forms.Button btnGeneralSaveDirectory;
    }
}

