using OfficeOpenXml;
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;

namespace SLC
{
    public partial class frmMain : Form
    {
        #region Fields
        public string SqlConnection;
        private bool SqlConnectionStatus;
        readonly int limit = 5;

        public string SlmServerPath; // this gets populated during LoadSettings()
        public string InvServerPath; // this gets populated during LoadSettings()
        public string LocalDestiniation; // this gets populated during LoadSettings()
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();

            LoadSettings(); // load the app.config
            LoadSettingsFieldAppender(); // applies settings to relevant fields
            AuthenticationMethod(); // load this after the settings have loaded
            ApplicationDirectories(); // create app directories if required
        }
        #endregion

        #region Tab: Snow License Manager
        private void btnDUJ_Click(object sender, EventArgs e)
        {
            try
            {
                string dujDirectory = LocalDestiniation + @"\Snow License Manager\";

                if(Directory.Exists(dujDirectory) == false)
                {
                    Directory.CreateDirectory(dujDirectory);
                }

                ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                foreach (DictionaryEntry entry in resourceSet)
                {
                    if (entry.Key.ToString().StartsWith("DUJ"))
                    {
                        DataTable dt;
                        dt = Laim.MSSqlServer.ExecuteReadDataTable(SqlConnection, (string)entry.Value);

                        DataExporter("DataUpdateJob-" + DateTime.Now.ToString("ddMMyyyy"), dujDirectory, "DUJ", dt, OfficeOpenXml.Table.TableStyles.None, (string)entry.Key);
                        dt.Dispose();
                    }
                }
                tsLblCollectorStatusValue.Text = "DUJ Logs Exported";
            }
            catch (Exception ex)
            {
                tsLblCollectorStatusValue.Text = "Failed, Check Logs";
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWebLogs_Click(object sender, EventArgs e)
        {
           try
            {
                string webLogsDirectory = LocalDestiniation + @"\Snow License Manager\Web\";

                LicenseManager.WebDirectoryCreator(webLogsDirectory);

                Global.LogFileCopier(SlmServerPath + LicenseManager.Application, limit, webLogsDirectory + LicenseManager.SLCApplication + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Error, limit, webLogsDirectory + LicenseManager.SLCError + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Security, limit, webLogsDirectory + LicenseManager.SLCSecurity + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.WebAPI, limit, webLogsDirectory + LicenseManager.SLCWebAPI + "\\");

                tsLblCollectorStatusValue.Text = "Web Logs Copied";

            } catch (Exception ex)
            {
                tsLblCollectorStatusValue.Text = "Failed, Check Logs";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSLMServicesLogs_Click(object sender, EventArgs e)
        {
            try
            { 
                string servicesLogsDirectory = LocalDestiniation + @"\Snow License Manager\Services\";

                #region File Copying

                LicenseManager.ServicesDirectoryCreator(servicesLogsDirectory);

                Global.LogFileCopier(SlmServerPath + LicenseManager.EventStore, limit, servicesLogsDirectory + LicenseManager.SLCEventStore + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.SlmImport, limit, servicesLogsDirectory + LicenseManager.SLCImportTool + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.InventoryService, limit, servicesLogsDirectory + LicenseManager.SLCInventoryAPI + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.NotificationDelivery, limit, servicesLogsDirectory + LicenseManager.SLCNotification + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Office365, limit, servicesLogsDirectory + LicenseManager.SLCOffice365 + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.ReportExport, limit, servicesLogsDirectory + LicenseManager.SLCReportExport + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Compliance, limit, servicesLogsDirectory + LicenseManager.SLCCompliance + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.LicensingService, limit, servicesLogsDirectory + LicenseManager.SLCLicensingService + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Licensing, limit, servicesLogsDirectory + LicenseManager.SLCLicensing + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.AdobeCC, limit, servicesLogsDirectory + LicenseManager.SLCAdobeCC + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.DataAccess, limit, servicesLogsDirectory + LicenseManager.SLCDataAccess + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.EventWarehouse, limit, servicesLogsDirectory + LicenseManager.SLCEventWarehouse + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.GenericSaaS, limit, servicesLogsDirectory + LicenseManager.SLCGenericSaaS + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.MaintenanceService, limit, servicesLogsDirectory + LicenseManager.SLCMaintenance + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.OracleManagement, limit, servicesLogsDirectory + LicenseManager.SLCOMO + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.SlmImport, limit, servicesLogsDirectory + LicenseManager.SLCSlmImport + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.SoftwareEnterpriseAgreement, limit, servicesLogsDirectory + LicenseManager.SLCSEAS + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.Virtualization, limit, servicesLogsDirectory + LicenseManager.SLCVirtualization + "\\");
                Global.LogFileCopier(SlmServerPath + LicenseManager.UpdateService, limit, servicesLogsDirectory + LicenseManager.SLCUpdateService + "\\");

                #endregion

                tsLblCollectorStatusValue.Text = "Services Logs Copied";

            }
            catch (Exception ex)
            {
                tsLblCollectorStatusValue.Text = "Failed, Check Logs";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSLMServicesLogsCustom_Click(object sender, EventArgs e)
        {
            using (Forms.frmSLMCustomizeGet f = new Forms.frmSLMCustomizeGet())
            {
                f.ServicesLogDirectory = LocalDestiniation + @"\Snow License Manager\Services\";
                f.SlmServerPath = SlmServerPath;
                f.limit = limit;
                f.ShowDialog();
            }
        }
        #endregion

        #region Tab: Snow Inventory
        private void btnInventoryAgentGet_Click(object sender, EventArgs e)
        {
            using (Forms.frmInventoryAgent f = new Forms.frmInventoryAgent())
            {
                f.Destination = LocalDestiniation;
                f.ShowDialog();
            }
        }

        private void btnSnowInventoryGet_Click(object sender, EventArgs e)
        {
            try
            {
                string InventoryLogsDirectory = LocalDestiniation + @"\Snow Inventory Server\";
                Inventory.InventoryDirectoryCreator(InventoryLogsDirectory);

                Global.LogFileCopier(InvServerPath + Inventory.InventoryServerLog, limit, InventoryLogsDirectory + Inventory.SLCServerLogs + @"\");
                Global.LogFileCopier(InvServerPath + Inventory.InventoryServerService, limit, InventoryLogsDirectory + Inventory.SLCServerManagerLogs + @"\");
                Global.LogFileCopier(InvServerPath + Inventory.InventoryUpdateService, limit, InventoryLogsDirectory + Inventory.SLCInventoryUpdate + @"\");

                tsLblCollectorStatusValue.Text = "Inventory Logs Copied";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tab: Settings
        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlConnectionStatus == true && txtSLMServer.TextLength > 0 && txtSLMDrive.TextLength > 0 && txtINVDrive.TextLength > 0 && txtINVServer.TextLength > 0 && txtGeneralSaveDirectory.TextLength > 0)
                {
                    string[] NodeList =
                    {
                        "SqlName",
                        "SqlUser",
                        "SqlPass",
                        "SqlAdditional",
                        "SqlStringFull",
                        "SLMServer",
                        "SLMDrive",
                        "INVServer",
                        "INVDrive",
                        "SaveDirectory",
                        "ExportTableDesign"
                    };

                    string[] ValueList =
                    {
                        txtSqlServerName.Text,
                        txtSqlServerUsername.Text,
                        Laim.Kryptos.Encrypt(txtSqlServerPassword.Text, Laim.Kryptos.GetHardwareID()),
                        txtSqlServerParameters.Text,
                        Laim.Kryptos.Encrypt(SqlConnection, Laim.Kryptos.GetHardwareID()),
                        txtSLMServer.Text,
                        txtSLMDrive.Text,
                        txtINVServer.Text,
                        txtINVDrive.Text,
                        txtGeneralSaveDirectory.Text,
                        cblReportingTableDesign.Text
                    };

                    Laim.XmlConfigurator.Write(Global.ConfigurationPath, NodeList, ValueList);

                    if (File.Exists(Global.ConfigurationPath))
                    {
                        MessageBox.Show("Configuration saved, the application will now restart.", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                else
                {
                   if(SqlConnectionStatus == false)
                    {
                        MessageBox.Show("Please test your SQL Connection.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else
                    {
                        MessageBox.Show("One or more required entries are empty.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSqlServerTest_Click(object sender, EventArgs e)
        {
            if (txtSqlServerName.TextLength > 0)
            {
                if (cbSqlServerWindowsAuth.Checked == true)
                {
                    SqlConnection = "Data Source=" + txtSqlServerName.Text + ";Application Name=SLC;Integrated Security=SSPI" + txtSqlServerParameters.Text;
                }
                else
                {
                    SqlConnection = "Data Source=" + txtSqlServerName.Text + ";Application Name=SLC;User=" + txtSqlServerUsername.Text + ";Password=" + txtSqlServerPassword.Text + txtSqlServerParameters.Text;
                }

                if (Laim.MSSqlServer.CheckConnnection(SqlConnection))
                {
                    SqlConnectionStatus = true;
                    MessageBox.Show("Connection Successful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                {
                    SqlConnectionStatus = false;
                    MessageBox.Show("Connection Unsuccessful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbSqlServerWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            AuthenticationMethod();
        }

        private void btnGeneralSaveDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            DialogResult result = fbg.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtGeneralSaveDirectory.Text = fbg.SelectedPath + @"\";
            }
        }

        private void btnConfigManager_Click(object sender, EventArgs e)
        {
            using (Forms.frmConfigurationTemplates f = new Forms.frmConfigurationTemplates())
            {
                f.ShowDialog();
            }
        }
        #endregion

        #region About
        private void lbLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbLibraries.SelectedItem.ToString())
            {
                case "EPPlus — 5.2":
                    txtLibraryInformation.Text = "EPPlus is a .NET library that reads and writes Excel 2007/2010/2013 files using the Open Office Xml format (xlsx).";
                    break;
                case "Laim.Utility — 1.5":
                    txtLibraryInformation.Text = "Closed-source utility used for most of my applications with pre-existing code modules.";
                    break;
            }
        }
        private void linkLaimScot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://laim.scot");
        #endregion

        #region Functions
        void DataExporter(string FileName, string Path, string DataType, DataTable dt, OfficeOpenXml.Table.TableStyles ReportingTableDesign, string SheetName = "Report")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var ep = new ExcelPackage(new FileInfo(Path + "\\" + FileName + ".xlsx")))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(SheetName);
                ew.Cells["A1"].LoadFromDataTable(dt, true, ReportingTableDesign);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = DataType + " Export";
                ep.Workbook.Properties.Company = "Goosetuv";
                ep.Workbook.Properties.Comments = "https://github.com/goosetuv";
                ep.Save();
            }
        }

        void AuthenticationMethod()
        {
            if (cbSqlServerWindowsAuth.Checked)
            {
                txtSqlServerPassword.Enabled = false;
                txtSqlServerUsername.Enabled = false;
            }
            else
            {
                txtSqlServerPassword.Enabled = true;
                txtSqlServerUsername.Enabled = true;
            }
        }

        void LoadSettings()
        {
            try
            {
                if (File.Exists(Global.ConfigurationPath))
                {
                    txtSqlServerName.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SqlName");
                    txtSqlServerUsername.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SqlUser");

                    string userPass = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SqlPass");
                    if (userPass.Length > 0)
                    {
                        txtSqlServerPassword.Text = Laim.Kryptos.Decrypt(userPass, Laim.Kryptos.GetHardwareID());
                    }
                    txtSqlServerParameters.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SqlAdditional");
                    SqlConnection = Laim.Kryptos.Decrypt(Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SqlStringFull"), Laim.Kryptos.GetHardwareID());
                    txtSLMServer.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SLMServer");
                    txtSLMDrive.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SLMDrive");
                    txtINVServer.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "INVServer");
                    txtINVDrive.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "INVDrive");
                    txtGeneralSaveDirectory.Text = Laim.XmlConfigurator.Read(Global.ConfigurationPath, "SaveDirectory");

                    int etd = 0;
                    foreach (string c in cblReportingTableDesign.Items)
                    {
                        if (c == Laim.XmlConfigurator.Read(Global.ConfigurationPath, "ExportTableDesign"))
                        {
                            cblReportingTableDesign.SelectedIndex = etd;
                        }
                        etd += 1;
                    }

                    if (txtSqlServerUsername.TextLength < 1)
                    {
                        cbSqlServerWindowsAuth.Checked = true;
                    }
                } else
                {
                    tabControlMain.SelectedIndex = 2;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadSettingsFieldAppender()
        {
            SlmServerPath = @"\\" + txtSLMServer.Text + @"\" + txtSLMDrive.Text;
            InvServerPath = @"\\" + txtINVServer.Text + @"\" + txtINVDrive.Text;
            LocalDestiniation = txtGeneralSaveDirectory.Text;
        }

        void ApplicationDirectories()
        {
            if(Directory.Exists(Global.ConfigurationTemplates) == false)
            {
                Directory.CreateDirectory(Global.ConfigurationTemplates);
            }
        }

        private string GetCopyright()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            object[] obj = asm.GetCustomAttributes(false);
            foreach (object o in obj)
            {
                if (o.GetType() ==
                    typeof(AssemblyCopyrightAttribute))
                {
                    AssemblyCopyrightAttribute aca =
            (AssemblyCopyrightAttribute)o;
                    return aca.Copyright;
                }
            }
            return string.Empty;
        }

        private string GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblAppVersion.Text = string.Format("Version {0}", GetVersion());
            lblAppCopyright.Text = GetCopyright();

            #if DEBUG

            lblAppVersion.Text = string.Format("Version {0} - {1}", GetVersion(), "Development Build");

            #endif
        }

    }
}
