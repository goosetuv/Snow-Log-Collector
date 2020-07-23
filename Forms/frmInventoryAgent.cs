using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SLC.Forms
{
    public partial class frmInventoryAgent : Form
    {

        #region Fields
        string InventoryAgentPath;
        string LocalPath;
        int LogCount;
        int SnowpackCount;
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
            try
            {
                if(txtDeviceName.TextLength > 0)
                {
                    lblPlsWait.Visible = true;
                    bool status = Inventory.PingDevice(txtDeviceName.Text);
                    if (status == true)
                    {
                        lblDeviceStatusValue.Text = "Online";
                        InventoryAgentPath = Inventory.GetSysInfo(txtDeviceName.Text, "Win32_Environment", txtUsername.Text, txtPassword.Text, cbUseCredentials.Checked);

                        if (InventoryAgentPath.Length > 5)
                        {
                            lblAgentServiceValue.Text = Inventory.GetSysInfo(txtDeviceName.Text, "Win32_Service", txtUsername.Text, txtPassword.Text, cbUseCredentials.Checked);
                            
                            // get the counter stats
                            GetFileCount();

                            // populate textboxes
                            lblPackCountValue.Text = SnowpackCount.ToString();
                            lblDeviceLogCountValue.Text = LogCount.ToString();

                            // button enabled
                            btnGetData.Enabled = true;
                        }
                    }
                    else
                    {
                        lblDeviceStatusValue.Text = "Offline";
                        InventoryAgentPath = "";
                        // button disabled
                        btnGetData.Enabled = false;
                    }
                    lblPlsWait.Visible = false;
                } else
                {
                    MessageBox.Show("Device name required.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if(InventoryAgentPath.Length > 0)
            {
                // create inventory agent directory 
                LocalPath = Destination + @"\Snow Inventory Agent\" + txtDeviceName.Text + @"\";
                if (Directory.Exists(LocalPath) == false)
                {
                    Directory.CreateDirectory(LocalPath);
                }

                if (cbUseCredentials.Checked)
                {
                    using (NetworkShareAccesser.Access(txtDeviceName.Text, txtUsername.Text, txtPassword.Text))
                    {
                        NetworkFileCopier();
                    }
                }
                else
                {
                    NetworkFileCopier();
                }
            } else
            {
                MessageBox.Show("Inventory path is null", "Inventory Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region Functions
        private void NetworkFileCopier()
        {
            foreach (var i in Directory.GetFiles(Inventory.ConvertDirectory(InventoryAgentPath, txtDeviceName.Text) + @"\data\").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).ToArray())
            {
                if (i.Extension.ToLower().Contains("log") || i.Extension.ToLower().Contains("snowpack"))
                {
                    File.Copy(i.FullName, LocalPath + i.Name);
                }
            }
        }

        private void GetFileCount()
        {
            // null out the counters
            LogCount = 0;
            SnowpackCount = 0;

            if (cbUseCredentials.Checked)
            {
                using (NetworkShareAccesser.Access(txtDeviceName.Text, txtUsername.Text, txtPassword.Text))
                {
                    foreach (var i in Directory.GetFiles(Inventory.ConvertDirectory(InventoryAgentPath, txtDeviceName.Text) + @"\data\").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).ToArray())
                    {
                        if (i.Extension.ToLower().Contains("log"))
                        {
                            LogCount += 1;
                        }
                        else if (i.Extension.ToLower().Contains("snowpack"))
                        {
                            SnowpackCount += 1;
                        }
                    }
                }
            }
            else
            {
                    foreach (var i in Directory.GetFiles(Inventory.ConvertDirectory(InventoryAgentPath, txtDeviceName.Text) + @"\data\").Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).ToArray())
                    {
                        if (i.Extension.ToLower().Contains("log"))
                        {
                            LogCount += 1;
                        }
                        else if (i.Extension.ToLower().Contains("snowpack"))
                        {
                            SnowpackCount += 1;
                        }
                    }
            }
        }
        #endregion

        private void txtDeviceName_TextChanged(object sender, EventArgs e)
        {
            btnGetData.Enabled = false;
        }
    }
}
