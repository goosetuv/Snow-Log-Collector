using OfficeOpenXml;
using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace SLC
{
    public partial class frmMain : Form
    {
        #region Fields
        public string SqlConnection;
        private bool SqlConnectionStatus;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
            AuthenticationMethod();
        }
        #endregion

        #region Snow License Manager Tab
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

                        DataExporter("DUJLog" + DateTime.Now.ToString("ddMMyyyy"), "DUJ", dt, OfficeOpenXml.Table.TableStyles.None, (string)entry.Key);
                    }
                }
                tsLblCollectorStatusValue.Text = "DUJ Logs Exported";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tsLblCollectorStatusValue.Text = "Failed, Check Logs";
            }
        }

        private void btnWebLogs_Click(object sender, EventArgs e)
        {
            int limit = 5;
            string slmAppLogs = "\\\\" + txtSLMServer.Text + "\\" + txtSLMDrive.Text + "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Application\\";
            string slmErrorLogs = "\\\\" + txtSLMServer.Text + "\\" + txtSLMDrive.Text + "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Error\\";
            string slmSecurityLogs = "\\\\" + txtSLMServer.Text + "\\" + txtSLMDrive.Text + "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Security\\";
            string slmAPILogs = "\\\\" + txtSLMServer.Text + "\\" + txtSLMDrive.Text + "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\WebApi\\";

            // app logs
            foreach (var i in Directory.GetFiles(slmAppLogs).Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).Take(limit).ToArray())
            {
                File.Copy(i.FullName, txtGeneralSaveDirectory.Text + "Application-" + i.Name);
            }

            // error logs
            foreach (var i in Directory.GetFiles(slmErrorLogs).Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).Take(limit).ToArray())
            {
                File.Copy(i.FullName, txtGeneralSaveDirectory.Text + "Error-" + i.Name);
            }

            // security logs
            foreach (var i in Directory.GetFiles(slmSecurityLogs).Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).Take(limit).ToArray())
            {
                File.Copy(i.FullName, txtGeneralSaveDirectory.Text + "Security-" + i.Name);
            }

            // api logs
            foreach (var i in Directory.GetFiles(slmAPILogs).Select(x => new FileInfo(x)).OrderByDescending(x => x.LastWriteTime).Take(limit).ToArray())
            {
                File.Copy(i.FullName, txtGeneralSaveDirectory.Text + "WebAPI-" + i.Name);
            }

        }
        #endregion

        #region Settings Tab
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
                    MessageBox.Show("One or more required entries are empty.", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

        #region Functions
        void DataExporter(string FileName, string DataType, DataTable dt, OfficeOpenXml.Table.TableStyles ReportingTableDesign, string SheetName = "Report")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var ep = new ExcelPackage(new FileInfo("C:\\temp\\" + FileName + ".xlsx")))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(SheetName);
                ew.Cells["A1"].LoadFromDataTable(dt, true, ReportingTableDesign);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = Application.ProductName;
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = DataType + " Export";
                ep.Workbook.Properties.Company = "Goosetuv Solutions";
                ep.Workbook.Properties.Comments = "https://laim.scot";
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
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
