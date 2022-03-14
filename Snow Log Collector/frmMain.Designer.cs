
namespace SnowLogCollector
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
            this.gbSLMPlatformData = new System.Windows.Forms.GroupBox();
            this.gbSLMPlatformDataGrab = new System.Windows.Forms.Button();
            this.lblSLMPlatformData = new System.Windows.Forms.Label();
            this.gbSLMLogsServices = new System.Windows.Forms.GroupBox();
            this.btnSLMLogsServicesCustomize = new System.Windows.Forms.Button();
            this.btnSLMLogsServicesGrab = new System.Windows.Forms.Button();
            this.lblSLMLogsServices = new System.Windows.Forms.Label();
            this.gbSLMLogsWeb = new System.Windows.Forms.GroupBox();
            this.btnSLMLogsWebCustomize = new System.Windows.Forms.Button();
            this.btnSLMLogsWebGrab = new System.Windows.Forms.Button();
            this.lblSLMLogsWeb = new System.Windows.Forms.Label();
            this.gbSLMDataUpdateJob = new System.Windows.Forms.GroupBox();
            this.btnSLMDataUpdateJobCustomize = new System.Windows.Forms.Button();
            this.btnSLMDataUpdateJobExport = new System.Windows.Forms.Button();
            this.lblSLMDataUpdateJob = new System.Windows.Forms.Label();
            this.tabSINV = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pbGoosetuvLogo = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabSLM.SuspendLayout();
            this.gbSLMPlatformData.SuspendLayout();
            this.gbSLMLogsServices.SuspendLayout();
            this.gbSLMLogsWeb.SuspendLayout();
            this.gbSLMDataUpdateJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoosetuvLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabSLM);
            this.tabControlMain.Controls.Add(this.tabSINV);
            this.tabControlMain.Controls.Add(this.tabConfig);
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Location = new System.Drawing.Point(0, 112);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(503, 265);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabSLM
            // 
            this.tabSLM.Controls.Add(this.gbSLMPlatformData);
            this.tabSLM.Controls.Add(this.gbSLMLogsServices);
            this.tabSLM.Controls.Add(this.gbSLMLogsWeb);
            this.tabSLM.Controls.Add(this.gbSLMDataUpdateJob);
            this.tabSLM.Location = new System.Drawing.Point(4, 22);
            this.tabSLM.Name = "tabSLM";
            this.tabSLM.Padding = new System.Windows.Forms.Padding(3);
            this.tabSLM.Size = new System.Drawing.Size(495, 239);
            this.tabSLM.TabIndex = 0;
            this.tabSLM.Text = "Snow License Manager";
            this.tabSLM.UseVisualStyleBackColor = true;
            // 
            // gbSLMPlatformData
            // 
            this.gbSLMPlatformData.Controls.Add(this.gbSLMPlatformDataGrab);
            this.gbSLMPlatformData.Controls.Add(this.lblSLMPlatformData);
            this.gbSLMPlatformData.Location = new System.Drawing.Point(10, 122);
            this.gbSLMPlatformData.Name = "gbSLMPlatformData";
            this.gbSLMPlatformData.Size = new System.Drawing.Size(200, 105);
            this.gbSLMPlatformData.TabIndex = 5;
            this.gbSLMPlatformData.TabStop = false;
            this.gbSLMPlatformData.Text = "Platform Data";
            // 
            // gbSLMPlatformDataGrab
            // 
            this.gbSLMPlatformDataGrab.Enabled = false;
            this.gbSLMPlatformDataGrab.Location = new System.Drawing.Point(118, 71);
            this.gbSLMPlatformDataGrab.Name = "gbSLMPlatformDataGrab";
            this.gbSLMPlatformDataGrab.Size = new System.Drawing.Size(75, 23);
            this.gbSLMPlatformDataGrab.TabIndex = 1;
            this.gbSLMPlatformDataGrab.Text = "Grab";
            this.gbSLMPlatformDataGrab.UseVisualStyleBackColor = true;
            // 
            // lblSLMPlatformData
            // 
            this.lblSLMPlatformData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLMPlatformData.Location = new System.Drawing.Point(9, 20);
            this.lblSLMPlatformData.Name = "lblSLMPlatformData";
            this.lblSLMPlatformData.Size = new System.Drawing.Size(184, 48);
            this.lblSLMPlatformData.TabIndex = 0;
            this.lblSLMPlatformData.Text = "Tested with Snow License Manager 9.17";
            this.lblSLMPlatformData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSLMLogsServices
            // 
            this.gbSLMLogsServices.Controls.Add(this.btnSLMLogsServicesCustomize);
            this.gbSLMLogsServices.Controls.Add(this.btnSLMLogsServicesGrab);
            this.gbSLMLogsServices.Controls.Add(this.lblSLMLogsServices);
            this.gbSLMLogsServices.Location = new System.Drawing.Point(285, 122);
            this.gbSLMLogsServices.Name = "gbSLMLogsServices";
            this.gbSLMLogsServices.Size = new System.Drawing.Size(200, 105);
            this.gbSLMLogsServices.TabIndex = 4;
            this.gbSLMLogsServices.TabStop = false;
            this.gbSLMLogsServices.Text = "Services Logs";
            // 
            // btnSLMLogsServicesCustomize
            // 
            this.btnSLMLogsServicesCustomize.Enabled = false;
            this.btnSLMLogsServicesCustomize.Location = new System.Drawing.Point(9, 71);
            this.btnSLMLogsServicesCustomize.Name = "btnSLMLogsServicesCustomize";
            this.btnSLMLogsServicesCustomize.Size = new System.Drawing.Size(75, 23);
            this.btnSLMLogsServicesCustomize.TabIndex = 2;
            this.btnSLMLogsServicesCustomize.Text = "Customize";
            this.btnSLMLogsServicesCustomize.UseVisualStyleBackColor = true;
            // 
            // btnSLMLogsServicesGrab
            // 
            this.btnSLMLogsServicesGrab.Enabled = false;
            this.btnSLMLogsServicesGrab.Location = new System.Drawing.Point(118, 71);
            this.btnSLMLogsServicesGrab.Name = "btnSLMLogsServicesGrab";
            this.btnSLMLogsServicesGrab.Size = new System.Drawing.Size(75, 23);
            this.btnSLMLogsServicesGrab.TabIndex = 1;
            this.btnSLMLogsServicesGrab.Text = "Grab";
            this.btnSLMLogsServicesGrab.UseVisualStyleBackColor = true;
            // 
            // lblSLMLogsServices
            // 
            this.lblSLMLogsServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLMLogsServices.Location = new System.Drawing.Point(9, 20);
            this.lblSLMLogsServices.Name = "lblSLMLogsServices";
            this.lblSLMLogsServices.Size = new System.Drawing.Size(184, 48);
            this.lblSLMLogsServices.TabIndex = 0;
            this.lblSLMLogsServices.Text = "Compatible with Snow License Manager 7.x, 8.x, 9.x";
            this.lblSLMLogsServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSLMLogsWeb
            // 
            this.gbSLMLogsWeb.Controls.Add(this.btnSLMLogsWebCustomize);
            this.gbSLMLogsWeb.Controls.Add(this.btnSLMLogsWebGrab);
            this.gbSLMLogsWeb.Controls.Add(this.lblSLMLogsWeb);
            this.gbSLMLogsWeb.Location = new System.Drawing.Point(285, 10);
            this.gbSLMLogsWeb.Name = "gbSLMLogsWeb";
            this.gbSLMLogsWeb.Size = new System.Drawing.Size(200, 105);
            this.gbSLMLogsWeb.TabIndex = 3;
            this.gbSLMLogsWeb.TabStop = false;
            this.gbSLMLogsWeb.Text = "Web Logs";
            // 
            // btnSLMLogsWebCustomize
            // 
            this.btnSLMLogsWebCustomize.Location = new System.Drawing.Point(9, 71);
            this.btnSLMLogsWebCustomize.Name = "btnSLMLogsWebCustomize";
            this.btnSLMLogsWebCustomize.Size = new System.Drawing.Size(75, 23);
            this.btnSLMLogsWebCustomize.TabIndex = 2;
            this.btnSLMLogsWebCustomize.Text = "Customize";
            this.btnSLMLogsWebCustomize.UseVisualStyleBackColor = true;
            this.btnSLMLogsWebCustomize.Click += new System.EventHandler(this.btnSLMLogsWebCustomize_Click);
            // 
            // btnSLMLogsWebGrab
            // 
            this.btnSLMLogsWebGrab.Location = new System.Drawing.Point(118, 71);
            this.btnSLMLogsWebGrab.Name = "btnSLMLogsWebGrab";
            this.btnSLMLogsWebGrab.Size = new System.Drawing.Size(75, 23);
            this.btnSLMLogsWebGrab.TabIndex = 1;
            this.btnSLMLogsWebGrab.Text = "Grab";
            this.btnSLMLogsWebGrab.UseVisualStyleBackColor = true;
            this.btnSLMLogsWebGrab.Click += new System.EventHandler(this.btnSLMLogsWebGrab_Click);
            // 
            // lblSLMLogsWeb
            // 
            this.lblSLMLogsWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLMLogsWeb.Location = new System.Drawing.Point(9, 20);
            this.lblSLMLogsWeb.Name = "lblSLMLogsWeb";
            this.lblSLMLogsWeb.Size = new System.Drawing.Size(184, 48);
            this.lblSLMLogsWeb.TabIndex = 0;
            this.lblSLMLogsWeb.Text = "Compatible with Snow License Manager 7.x, 8.x, 9.x";
            this.lblSLMLogsWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbSLMDataUpdateJob
            // 
            this.gbSLMDataUpdateJob.Controls.Add(this.btnSLMDataUpdateJobCustomize);
            this.gbSLMDataUpdateJob.Controls.Add(this.btnSLMDataUpdateJobExport);
            this.gbSLMDataUpdateJob.Controls.Add(this.lblSLMDataUpdateJob);
            this.gbSLMDataUpdateJob.Location = new System.Drawing.Point(10, 10);
            this.gbSLMDataUpdateJob.Name = "gbSLMDataUpdateJob";
            this.gbSLMDataUpdateJob.Size = new System.Drawing.Size(200, 105);
            this.gbSLMDataUpdateJob.TabIndex = 0;
            this.gbSLMDataUpdateJob.TabStop = false;
            this.gbSLMDataUpdateJob.Text = "Data Update Job";
            // 
            // btnSLMDataUpdateJobCustomize
            // 
            this.btnSLMDataUpdateJobCustomize.Location = new System.Drawing.Point(9, 71);
            this.btnSLMDataUpdateJobCustomize.Name = "btnSLMDataUpdateJobCustomize";
            this.btnSLMDataUpdateJobCustomize.Size = new System.Drawing.Size(75, 23);
            this.btnSLMDataUpdateJobCustomize.TabIndex = 2;
            this.btnSLMDataUpdateJobCustomize.Text = "Customize";
            this.btnSLMDataUpdateJobCustomize.UseVisualStyleBackColor = true;
            this.btnSLMDataUpdateJobCustomize.Click += new System.EventHandler(this.btnSLMDataUpdateJobCustomize_Click);
            // 
            // btnSLMDataUpdateJobExport
            // 
            this.btnSLMDataUpdateJobExport.Location = new System.Drawing.Point(118, 71);
            this.btnSLMDataUpdateJobExport.Name = "btnSLMDataUpdateJobExport";
            this.btnSLMDataUpdateJobExport.Size = new System.Drawing.Size(75, 23);
            this.btnSLMDataUpdateJobExport.TabIndex = 1;
            this.btnSLMDataUpdateJobExport.Text = "Export";
            this.btnSLMDataUpdateJobExport.UseVisualStyleBackColor = true;
            this.btnSLMDataUpdateJobExport.Click += new System.EventHandler(this.btnSLMDataUpdateJobExport_Click);
            // 
            // lblSLMDataUpdateJob
            // 
            this.lblSLMDataUpdateJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLMDataUpdateJob.Location = new System.Drawing.Point(9, 20);
            this.lblSLMDataUpdateJob.Name = "lblSLMDataUpdateJob";
            this.lblSLMDataUpdateJob.Size = new System.Drawing.Size(184, 48);
            this.lblSLMDataUpdateJob.TabIndex = 0;
            this.lblSLMDataUpdateJob.Text = "Compatible with Snow License Manager 9.x";
            this.lblSLMDataUpdateJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSINV
            // 
            this.tabSINV.Location = new System.Drawing.Point(4, 22);
            this.tabSINV.Name = "tabSINV";
            this.tabSINV.Padding = new System.Windows.Forms.Padding(3);
            this.tabSINV.Size = new System.Drawing.Size(495, 239);
            this.tabSINV.TabIndex = 1;
            this.tabSINV.Text = "Snow Inventory Server";
            this.tabSINV.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(495, 239);
            this.tabConfig.TabIndex = 3;
            this.tabConfig.Text = "Configuration";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(495, 239);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // pbGoosetuvLogo
            // 
            this.pbGoosetuvLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbGoosetuvLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbGoosetuvLogo.Image")));
            this.pbGoosetuvLogo.Location = new System.Drawing.Point(0, 0);
            this.pbGoosetuvLogo.Name = "pbGoosetuvLogo";
            this.pbGoosetuvLogo.Size = new System.Drawing.Size(503, 106);
            this.pbGoosetuvLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGoosetuvLogo.TabIndex = 0;
            this.pbGoosetuvLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 377);
            this.Controls.Add(this.pbGoosetuvLogo);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snow Log Collector";
            this.tabControlMain.ResumeLayout(false);
            this.tabSLM.ResumeLayout(false);
            this.gbSLMPlatformData.ResumeLayout(false);
            this.gbSLMLogsServices.ResumeLayout(false);
            this.gbSLMLogsWeb.ResumeLayout(false);
            this.gbSLMDataUpdateJob.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGoosetuvLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSLM;
        private System.Windows.Forms.TabPage tabSINV;
        private System.Windows.Forms.PictureBox pbGoosetuvLogo;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.GroupBox gbSLMDataUpdateJob;
        private System.Windows.Forms.Label lblSLMDataUpdateJob;
        private System.Windows.Forms.Button btnSLMDataUpdateJobExport;
        private System.Windows.Forms.Button btnSLMDataUpdateJobCustomize;
        private System.Windows.Forms.GroupBox gbSLMLogsWeb;
        private System.Windows.Forms.Button btnSLMLogsWebCustomize;
        private System.Windows.Forms.Button btnSLMLogsWebGrab;
        private System.Windows.Forms.Label lblSLMLogsWeb;
        private System.Windows.Forms.GroupBox gbSLMLogsServices;
        private System.Windows.Forms.Button btnSLMLogsServicesCustomize;
        private System.Windows.Forms.Button btnSLMLogsServicesGrab;
        private System.Windows.Forms.Label lblSLMLogsServices;
        private System.Windows.Forms.GroupBox gbSLMPlatformData;
        private System.Windows.Forms.Button gbSLMPlatformDataGrab;
        private System.Windows.Forms.Label lblSLMPlatformData;
        private System.Windows.Forms.TabPage tabConfig;
    }
}

