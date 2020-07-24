namespace SLC.Forms
{
    partial class frmConfigurationTemplates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurationTemplates));
            this.lbConfigurations = new System.Windows.Forms.ListBox();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConfigurations
            // 
            this.lbConfigurations.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.lbConfigurations.FormattingEnabled = true;
            this.lbConfigurations.ItemHeight = 14;
            this.lbConfigurations.Location = new System.Drawing.Point(12, 12);
            this.lbConfigurations.Name = "lbConfigurations";
            this.lbConfigurations.Size = new System.Drawing.Size(217, 158);
            this.lbConfigurations.TabIndex = 0;
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(12, 186);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(108, 23);
            this.btnLoadConfig.TabIndex = 1;
            this.btnLoadConfig.Text = "Load Configuration";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // frmConfigurationTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(242, 221);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.lbConfigurations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigurationTemplates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration Templates";
            this.Load += new System.EventHandler(this.frmConfigurationManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConfigurations;
        private System.Windows.Forms.Button btnLoadConfig;
    }
}