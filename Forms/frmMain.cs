using OfficeOpenXml;
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using Microsoft.VisualBasic;
using System.Resources;
using System.Windows.Forms;

namespace SLC
{
    public partial class frmMain : Form
    {
        #region Fields
        public string SqlConnection;
        private bool SqlConnectionStatus;
        readonly int limit = 5;

        public string SlmServerPath; // this gets populated during LoadSettings()
        public string LocalDestiniation;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
            LoadSettingsFieldAppender();
            AuthenticationMethod();
        }
        #endregion

        #region Tab: Snow License Manager
        private void btnDUJ_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                foreach (DictionaryEntry entry in resourceSet)
                {
                    if (entry.Key.ToString().StartsWith("DUJ"))
                    {
                        DataTable dt;
                        dt = Laim.MSSqlServer.ExecuteReadDataTable(SqlConnection, (string)entry.Value);

                        DataExporter("DataUpdateJob-" + DateTime.Now.ToString("ddMMyyyy"), LocalDestiniation, "DUJ", dt, OfficeOpenXml.Table.TableStyles.None, (string)entry.Key);
                        dt.Dispose();
                    }
                }
                tsLblCollectorStatusValue.Text = "DUJ Logs Exported";
            }
            catch (Exception ex)
            {
                tsLblCollectorStatusValue.Text = "Failed, Check Logs";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWebLogs_Click(object sender, EventArgs e)
        {
           try
            {
                string webLogsDirectory = LocalDestiniation + "\\WebLogs\\";

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
                string servicesLogsDirectory = LocalDestiniation + "\\ServicesLogs\\";

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
                f.ServicesLogDirectory = LocalDestiniation + "\\ServicesLogs\\";
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

                    Laim.XmlConfigurator.Write("app.config", NodeList, ValueList);

                    if (File.Exists("app.config"))
                    {
                        MessageBox.Show("Configuration Saved", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                txtGeneralSaveDirectory.Text = fbg.SelectedPath;
            }
        }
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
                if (File.Exists("app.config"))
                {
                    txtSqlServerName.Text = Laim.XmlConfigurator.Read("app.config", "SqlName");
                    txtSqlServerUsername.Text = Laim.XmlConfigurator.Read("app.config", "SqlUser");

                    string userPass = Laim.XmlConfigurator.Read("app.config", "SqlPass");
                    if (userPass.Length > 0)
                    {
                        txtSqlServerPassword.Text = Laim.Kryptos.Decrypt(userPass, Laim.Kryptos.GetHardwareID());
                    }
                    txtSqlServerParameters.Text = Laim.XmlConfigurator.Read("app.config", "SqlAdditional");
                    SqlConnection = Laim.Kryptos.Decrypt(Laim.XmlConfigurator.Read("app.config", "SqlStringFull"), Laim.Kryptos.GetHardwareID());
                    txtSLMServer.Text = Laim.XmlConfigurator.Read("app.config", "SLMServer");
                    txtSLMDrive.Text = Laim.XmlConfigurator.Read("app.config", "SLMDrive");
                    txtINVServer.Text = Laim.XmlConfigurator.Read("app.config", "INVServer");
                    txtINVDrive.Text = Laim.XmlConfigurator.Read("app.config", "INVDrive");
                    txtGeneralSaveDirectory.Text = Laim.XmlConfigurator.Read("app.config", "SaveDirectory");

                    int etd = 0;
                    foreach (string c in cblReportingTableDesign.Items)
                    {
                        if (c == Laim.XmlConfigurator.Read("app.config", "ExportTableDesign"))
                        {
                            cblReportingTableDesign.SelectedIndex = etd;
                        } else
                        {
                            cblReportingTableDesign.SelectedIndex = 0;
                        }
                        etd += 1;
                    }

                    if(txtSqlServerUsername.TextLength < 1)
                    {
                        cbSqlServerWindowsAuth.Checked = true;
                    }
                } else
                {
                    tabControlMain.SelectedIndex = 2;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void LoadSettingsFieldAppender()
        {
            SlmServerPath = "\\\\" + txtSLMServer.Text + "\\" + txtSLMDrive.Text;
            LocalDestiniation = txtGeneralSaveDirectory.Text;
        }
        #endregion

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/goosetuv/snow-log-collector/wiki");
        }

    }
}
