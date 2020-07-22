using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SLC.Forms
{
    public partial class frmInventoryAgent : Form
    {

        #region Fields
        string InventoryAgentPath;
        public string Destination { get; set; }
        #endregion

        #region Constructor
        public frmInventoryAgent()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            lblPlsWait.Visible = true;
            bool status = Inventory.PingDevice(txtDeviceName.Text);
            if (status == true)
            {
                lblDeviceStatusValue.Text = "Online";
                lblDeviceStatusValue.ForeColor = Color.Green;
                InventoryAgentPath = Inventory.GetSysInfo(txtDeviceName.Text, txtUsername.Text, txtPassword.Text, cbUseCredentials.Checked);
                // button enabled
                btnGetData.Enabled = true;
            }
            else
            {
                lblDeviceStatusValue.Text = "Offline";
                lblDeviceStatusValue.ForeColor = Color.Red;
                InventoryAgentPath = "";
                // button disabled
                btnGetData.Enabled = false;
            }
            lblPlsWait.Visible = false;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if(InventoryAgentPath.Length > 0)
            {
                // create inventory agent directory 
                string LocalPath = Destination + @"\SnowInventory\" + txtDeviceName.Text + @"\";
                if (Directory.Exists(LocalPath) == false)
                {
                    Directory.CreateDirectory(LocalPath);
                }

                if (cbUseCredentials.Checked)
                {
                    using (NetworkShareAccesser.Access(txtDeviceName.Text, txtUsername.Text, txtPassword.Text))
                    {
                        foreach (var i in Directory.GetFiles(Inventory.ConvertDirectory(InventoryAgentPath, txtDeviceName.Text) + @"\data\").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).ToArray())
                        {
                            if (i.Extension.ToLower().Contains("log") || i.Extension.ToLower().Contains("snowpack"))
                            {
                                File.Copy(i.FullName, LocalPath + i.Name);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var i in Directory.GetFiles(Inventory.ConvertDirectory(InventoryAgentPath, txtDeviceName.Text) + @"\data\").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).ToArray())
                    {
                        if (i.Extension.ToLower().Contains("log") || i.Extension.ToLower().Contains("snowpack"))
                        {
                            File.Copy(i.FullName, LocalPath + i.Name);
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Inventory path is null", "Inventory Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        private void txtDeviceName_TextChanged(object sender, EventArgs e)
        {
            btnGetData.Enabled = false;
        }

        private void frmInventoryAgent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please note that this page is in Alpha, it works for machines on the same domain and machines on a different domain with credentials required.  It's still in alpha status as it doesn't pull all information I want, and it can be quite glitchy.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
