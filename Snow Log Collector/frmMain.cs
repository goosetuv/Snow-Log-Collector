using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using SnowLogCollector.Classes;
using OfficeOpenXml.Table;

namespace SnowLogCollector
{
    public partial class frmMain : Form
    {
        private DatabaseManager dbm = new DatabaseManager();
        private DirectoryManager dir = new DirectoryManager(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Goosetuv\Snow Log Collector\");
        private bool isSqlValid = false; // only important when saving config

        public frmMain()
        {
            InitializeComponent();

            dir.CreateDirectories();

            try
            {
                dbm.ConnectionString = ConfigManager.ConnectionGet();
            } catch { }

            PopulateConfigurationData();
        }

        #region Snow License Manager
        private void btnSLMDataUpdateJobCustomize_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists(Path.Combine(dir.Resource, "DataUpdateJob.xml")))
                {
                    Process.Start(Path.Combine(dir.Resource, "DataUpdateJob.xml"));
                }
                else
                {
                    MessageBox.Show("Please use the default grab before trying to customize.", "Update Job Customize", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Job Customize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSLMLogsWebGrab_Click(object sender, EventArgs e)
        {
            string unc = ConfigManager.AppSettingsGet("SnowLicenseManagerServerUNC");
            string web = ConfigManager.AppSettingsGet("SnowLicenseManagerWebLogs");

            foreach (var i in Directory.GetDirectories(Path.Combine(unc, web)))
            {
                MessageBox.Show(i);
            }
        }

        private void btnSLMLogsWebCustomize_Click(object sender, EventArgs e)
        {
            string unc = ConfigManager.AppSettingsGet("SnowLicenseManagerServerUNC");
            string web = ConfigManager.AppSettingsGet("SnowLicenseManagerWebLogs");

            frmDirectoryCustomize fdc = new frmDirectoryCustomize
            {
                FormName = "License Manager Web Logs",
                DirectoryPath = Path.Combine(unc, web)
            };

            fdc.ShowDialog();
        }

        private void btnSLMDataUpdateJobExport_Click(object sender, EventArgs e)
        {
            string resourceFile = Path.Combine(dir.Resource, "DataUpdateJob.xml");
            Guid fileName = Guid.NewGuid();

            // Write sql scripts to file so they can be modified later by end user.
            // Create this when using the feature rather at on-load, in case the
            // end user never actually uses this option, no point having wasteful files
            // Using the if statement so it doesn't overwrite the file if it exists
            // as it'll remove any customization.
            if (!File.Exists(resourceFile))
            {
                File.WriteAllText(resourceFile, Properties.Resources.DataUpdateJob);
            }

            // Load up the file that contains our SQL Scripts for
            // running against the database
            XDocument xdoc = XDocument.Load(resourceFile);

            // Initiate the Excel Exporter and Database Manager
            ExcelExporter ee = new ExcelExporter();

            // Loop through each node, we do this instead of hardcoding them
            // So that an end user can add custom scripts at a later date
            // If they want to.  This also means that if something changes
            // and I'm too busy or lazy to update the tool, end user can
            // update the script themselves - nice! 
            foreach (XElement element in xdoc.Descendants())
            {
                if (element.Name.ToString() != "Resource") // Ignore the root node
                {
                    // Make sure no one has added a DELETE, TRUNCATE or UPDATE query ... 
                    if (!element.Value.ToString().Contains("DELETE") || !element.Value.ToString().Contains("TRUNCATE") || !element.Value.ToString().Contains("UPDATE"))
                    {
                        ee.Save(
                            fileName,                                               // Filename
                            dir.Export,                                              // Export Path
                            ExcelExporter.DataType.DataUpdateJob,                   // Data Type
                            dbm.ExecuteQuery(element.Value.ToString()),             // Database Execution
                            TableStyles.Light10,                                    // Table Style
                            element.Name.ToString()                                 // Name of Sql Script
                        );

                    }

                }
            }

        }

        #endregion

        #region Configuration 
        private void PopulateConfigurationData()
        {
            txtConfigLicenseManagerServer.Text = ConfigManager.AppSettingsGet("SnowLicenseManagerServer");
            txtConfigSnowInventoryServer.Text = ConfigManager.AppSettingsGet("SnowInventoryServer");
            cbConfigLicenseManagerDrive.Text = ConfigManager.AppSettingsGet("SnowLicenseManagerDrive");
            cbConfigSnowInventoryDrive.Text = ConfigManager.AppSettingsGet("SnowInventoryDrive");

            txtConfigDatabaseServer.Text = dbm.DemolishConnectionString("Server");
            txtConfigDatabaseUser.Text = dbm.DemolishConnectionString("User ID");
            txtConfigDatabasePass.Text = dbm.DemolishConnectionString("Password");
            cbxConfigDatabaseWinAuth.Checked = bool.Parse(dbm.DemolishConnectionString("Integrated Security"));
        }

        private void btnConfigServersSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtConfigLicenseManagerServer.Text))
            {
                MessageBox.Show("Snow License Manager Server hostname is required.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConfigSnowInventoryServer.Text) && isValid)
            {
                MessageBox.Show("Snow Inventory Server hostname is required.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cbConfigLicenseManagerDrive.Text) && isValid)
            {
                MessageBox.Show("Snow License Manager Server installation drive letter is required.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cbConfigSnowInventoryDrive.Text) && isValid)
            {
                MessageBox.Show("Snow Inventory Server installation drive letter is required.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (isValid)
            {
                ConfigManager.AppSettingsSet("SnowLicenseManagerServer", txtConfigLicenseManagerServer.Text);
                ConfigManager.AppSettingsSet("SnowInventoryServer", txtConfigSnowInventoryServer.Text);
                ConfigManager.AppSettingsSet("SnowLicenseManagerDrive", cbConfigLicenseManagerDrive.Text);
                ConfigManager.AppSettingsSet("SnowInventoryDrive", cbConfigSnowInventoryDrive.Text);
                ConfigManager.AppSettingsSet("SnowLicenseManagerServerUNC", string.Format(@"\\{0}\{1}$\", txtConfigLicenseManagerServer.Text, cbConfigLicenseManagerDrive.Text));
                ConfigManager.AppSettingsSet("SnowInventoryServerUNC", string.Format(@"\\{0}\{1}$\", txtConfigSnowInventoryServer.Text, cbConfigSnowInventoryDrive.Text));

                MessageBox.Show("Server Configuration saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cbxConfigDatabaseWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxConfigDatabaseWinAuth.Checked)
            {
                txtConfigDatabaseUser.Enabled = false;
                txtConfigDatabasePass.Enabled = false;
            }
            else
            {
                txtConfigDatabaseUser.Enabled = true;
                txtConfigDatabasePass.Enabled = true;
            }
        }

        private void btnConfigDatabaseSave_Click(object sender, EventArgs e)
        {
            string oldConnectionString = dbm.ConnectionString;

            if (isSqlValid)
            {
                dbm.ConnectionString = dbm.BuildConnectionString(txtConfigDatabaseServer.Text, txtConfigDatabaseUser.Text, txtConfigDatabasePass.Text, cbxConfigDatabaseWinAuth.Checked);

                // Check if the account we're using is in the SYSADMIN group
                bool isSysAdmin = bool.Parse(dbm.ExecuteQueryScalar("SELECT CASE WHEN IS_SRVROLEMEMBER('sysadmin') = 1 THEN 'True' ELSE 'False' END", ""));
                DialogResult dr;

                if (isSysAdmin)
                {
                    // Show warning message because we don't need SA rights and I'm not being blamed for
                    // a password being unhashed, I ain't a security guy
                    dr = MessageBox.Show("As this application is open source, there is only so much I can do for hashing connection strings.  A user on the same machine cannot unhash your password, but anyone that gains access to your account can.  It is recommended NOT to use a full-access account with this tool and to give it read permissions only.  Do you wish to continue with an SA account?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        // Save the new connection string using the SA account
                        ConfigManager.ConnectionSet(dbm.ConnectionString);

                        // Tell user we're saved
                        MessageBox.Show("Database Configuration saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Set our connection string back to the old one
                        dbm.ConnectionString = oldConnectionString;
                    }

                }
                else
                {
                    // Save the new connection string using a NON-SA account
                    ConfigManager.ConnectionSet(dbm.ConnectionString);

                    // Tell the user we're saved
                    MessageBox.Show("Database Configuration saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please test the connection before saving.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigDatabaseTest_Click(object sender, EventArgs e)
        {
            // build our connection string and then pass it to testconnectionstring to confirm we good
            if (dbm.TestConnectionString(dbm.BuildConnectionString(txtConfigDatabaseServer.Text, txtConfigDatabaseUser.Text, txtConfigDatabasePass.Text, cbxConfigDatabaseWinAuth.Checked)))
            {
                // Show user a successful message
                MessageBox.Show("Connection to database is valid.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSqlValid = true;

            }
            else
            {
                // It didn't work lol
                MessageBox.Show("Connection to database failed.  Please check and confirm details and that this server is able to access the database server.", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                isSqlValid = false;
            }
        }
        #endregion

        #region About Tab
        private void btnAboutAppData_Click(object sender, EventArgs e)
        {
            Process.Start(dir.Data);
        }

        private void lblAboutLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblAboutLibraries.SelectedItem.ToString().Contains("EPP"))
            {
                txtAboutLibrariesLicense.Text = "https://github.com/EPPlusSoftware/EPPlus/blob/develop/license.md";
            }
        }
        #endregion


    }
}
