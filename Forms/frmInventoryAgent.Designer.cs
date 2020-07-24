namespace SLC.Forms
{
    partial class frmInventoryAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryAgent));
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.gbDeviceInformation = new System.Windows.Forms.GroupBox();
            this.lblAgentServiceValue = new System.Windows.Forms.Label();
            this.lblAgentService = new System.Windows.Forms.Label();
            this.lblPackCountValue = new System.Windows.Forms.Label();
            this.lblPackCount = new System.Windows.Forms.Label();
            this.lblDeviceLogCountValue = new System.Windows.Forms.Label();
            this.lblDeviceLogCount = new System.Windows.Forms.Label();
            this.lblDeviceStatusValue = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.cbUseCredentials = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPlsWait = new System.Windows.Forms.Label();
            this.gbDeviceInformation.SuspendLayout();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(20, 20);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(75, 13);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(101, 17);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(219, 20);
            this.txtDeviceName.TabIndex = 1;
            this.txtDeviceName.TextChanged += new System.EventHandler(this.txtDeviceName_TextChanged);
            // 
            // gbDeviceInformation
            // 
            this.gbDeviceInformation.Controls.Add(this.lblAgentServiceValue);
            this.gbDeviceInformation.Controls.Add(this.lblAgentService);
            this.gbDeviceInformation.Controls.Add(this.lblPackCountValue);
            this.gbDeviceInformation.Controls.Add(this.lblPackCount);
            this.gbDeviceInformation.Controls.Add(this.lblDeviceLogCountValue);
            this.gbDeviceInformation.Controls.Add(this.lblDeviceLogCount);
            this.gbDeviceInformation.Controls.Add(this.lblDeviceStatusValue);
            this.gbDeviceInformation.Controls.Add(this.lblDeviceStatus);
            this.gbDeviceInformation.Location = new System.Drawing.Point(20, 50);
            this.gbDeviceInformation.Name = "gbDeviceInformation";
            this.gbDeviceInformation.Size = new System.Drawing.Size(300, 103);
            this.gbDeviceInformation.TabIndex = 2;
            this.gbDeviceInformation.TabStop = false;
            this.gbDeviceInformation.Text = "Information";
            // 
            // lblAgentServiceValue
            // 
            this.lblAgentServiceValue.AutoSize = true;
            this.lblAgentServiceValue.Location = new System.Drawing.Point(130, 80);
            this.lblAgentServiceValue.Name = "lblAgentServiceValue";
            this.lblAgentServiceValue.Size = new System.Drawing.Size(16, 13);
            this.lblAgentServiceValue.TabIndex = 7;
            this.lblAgentServiceValue.Text = "...";
            // 
            // lblAgentService
            // 
            this.lblAgentService.AutoSize = true;
            this.lblAgentService.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentService.Location = new System.Drawing.Point(36, 80);
            this.lblAgentService.Name = "lblAgentService";
            this.lblAgentService.Size = new System.Drawing.Size(81, 14);
            this.lblAgentService.TabIndex = 6;
            this.lblAgentService.Text = "Agent Service:";
            // 
            // lblPackCountValue
            // 
            this.lblPackCountValue.AutoSize = true;
            this.lblPackCountValue.Location = new System.Drawing.Point(130, 60);
            this.lblPackCountValue.Name = "lblPackCountValue";
            this.lblPackCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblPackCountValue.TabIndex = 5;
            this.lblPackCountValue.Text = "0";
            // 
            // lblPackCount
            // 
            this.lblPackCount.AutoSize = true;
            this.lblPackCount.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackCount.Location = new System.Drawing.Point(20, 60);
            this.lblPackCount.Name = "lblPackCount";
            this.lblPackCount.Size = new System.Drawing.Size(98, 14);
            this.lblPackCount.TabIndex = 4;
            this.lblPackCount.Text = "Snowpack Count:";
            // 
            // lblDeviceLogCountValue
            // 
            this.lblDeviceLogCountValue.AutoSize = true;
            this.lblDeviceLogCountValue.Location = new System.Drawing.Point(130, 40);
            this.lblDeviceLogCountValue.Name = "lblDeviceLogCountValue";
            this.lblDeviceLogCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblDeviceLogCountValue.TabIndex = 3;
            this.lblDeviceLogCountValue.Text = "0";
            // 
            // lblDeviceLogCount
            // 
            this.lblDeviceLogCount.AutoSize = true;
            this.lblDeviceLogCount.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceLogCount.Location = new System.Drawing.Point(53, 40);
            this.lblDeviceLogCount.Name = "lblDeviceLogCount";
            this.lblDeviceLogCount.Size = new System.Drawing.Size(65, 14);
            this.lblDeviceLogCount.TabIndex = 2;
            this.lblDeviceLogCount.Text = "Log Count:";
            // 
            // lblDeviceStatusValue
            // 
            this.lblDeviceStatusValue.AutoSize = true;
            this.lblDeviceStatusValue.Location = new System.Drawing.Point(130, 20);
            this.lblDeviceStatusValue.Name = "lblDeviceStatusValue";
            this.lblDeviceStatusValue.Size = new System.Drawing.Size(52, 13);
            this.lblDeviceStatusValue.TabIndex = 1;
            this.lblDeviceStatusValue.Text = "Waiting...";
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeviceStatus.Location = new System.Drawing.Point(75, 19);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(42, 14);
            this.lblDeviceStatus.TabIndex = 0;
            this.lblDeviceStatus.Text = "Status:";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(20, 265);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(95, 23);
            this.btnGetInfo.TabIndex = 3;
            this.btnGetInfo.Text = "Check Status";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(225, 265);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(95, 23);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Controls.Add(this.cbUseCredentials);
            this.gbLoginInformation.Controls.Add(this.lblPassword);
            this.gbLoginInformation.Controls.Add(this.lblUsername);
            this.gbLoginInformation.Controls.Add(this.txtPassword);
            this.gbLoginInformation.Controls.Add(this.txtUsername);
            this.gbLoginInformation.Location = new System.Drawing.Point(20, 159);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(300, 100);
            this.gbLoginInformation.TabIndex = 6;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "System Login (Optional)";
            // 
            // cbUseCredentials
            // 
            this.cbUseCredentials.AutoSize = true;
            this.cbUseCredentials.Location = new System.Drawing.Point(128, 69);
            this.cbUseCredentials.Name = "cbUseCredentials";
            this.cbUseCredentials.Size = new System.Drawing.Size(100, 17);
            this.cbUseCredentials.TabIndex = 8;
            this.cbUseCredentials.Text = "Use Credentials";
            this.cbUseCredentials.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(62, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 14);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(60, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 14);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 17);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPlsWait
            // 
            this.lblPlsWait.AutoSize = true;
            this.lblPlsWait.Location = new System.Drawing.Point(129, 270);
            this.lblPlsWait.Name = "lblPlsWait";
            this.lblPlsWait.Size = new System.Drawing.Size(73, 13);
            this.lblPlsWait.TabIndex = 7;
            this.lblPlsWait.Text = "Please Wait...";
            this.lblPlsWait.Visible = false;
            // 
            // frmInventoryAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 300);
            this.Controls.Add(this.lblPlsWait);
            this.Controls.Add(this.gbLoginInformation);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.gbDeviceInformation);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.lblDeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInventoryAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Agent";
            this.gbDeviceInformation.ResumeLayout(false);
            this.gbDeviceInformation.PerformLayout();
            this.gbLoginInformation.ResumeLayout(false);
            this.gbLoginInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.GroupBox gbDeviceInformation;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label lblDeviceStatusValue;
        private System.Windows.Forms.Label lblDeviceLogCountValue;
        private System.Windows.Forms.Label lblDeviceLogCount;
        private System.Windows.Forms.Label lblPackCount;
        private System.Windows.Forms.Label lblPackCountValue;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox cbUseCredentials;
        private System.Windows.Forms.Label lblPlsWait;
        private System.Windows.Forms.Label lblAgentService;
        private System.Windows.Forms.Label lblAgentServiceValue;
    }
}