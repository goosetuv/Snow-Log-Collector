
namespace SnowLogCollector
{
    partial class frmDirectoryCustomize
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
            this.clbDirectoryList = new System.Windows.Forms.CheckedListBox();
            this.btnGrabData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDirectoryList
            // 
            this.clbDirectoryList.CheckOnClick = true;
            this.clbDirectoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbDirectoryList.FormattingEnabled = true;
            this.clbDirectoryList.Location = new System.Drawing.Point(0, 0);
            this.clbDirectoryList.Name = "clbDirectoryList";
            this.clbDirectoryList.Size = new System.Drawing.Size(208, 259);
            this.clbDirectoryList.TabIndex = 0;
            // 
            // btnGrabData
            // 
            this.btnGrabData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGrabData.Location = new System.Drawing.Point(0, 259);
            this.btnGrabData.Name = "btnGrabData";
            this.btnGrabData.Size = new System.Drawing.Size(208, 23);
            this.btnGrabData.TabIndex = 1;
            this.btnGrabData.Text = "Grab Data";
            this.btnGrabData.UseVisualStyleBackColor = true;
            this.btnGrabData.Click += new System.EventHandler(this.btnGrabData_Click);
            // 
            // frmDirectoryCustomize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 282);
            this.Controls.Add(this.btnGrabData);
            this.Controls.Add(this.clbDirectoryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDirectoryCustomize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirectoryCustomize";
            this.Load += new System.EventHandler(this.frmDirectoryCustomize_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbDirectoryList;
        private System.Windows.Forms.Button btnGrabData;
    }
}