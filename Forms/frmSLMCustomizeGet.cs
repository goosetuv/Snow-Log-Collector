using System;
using System.IO;
using System.Windows.Forms;

namespace SLC.Forms
{
    public partial class frmSLMCustomizeGet : Form
    {
        public string ServicesLogDirectory { get; set; }
        public string SlmServerPath { get; set; }
        public int limit { get; set; }

        #region Constructor
        public frmSLMCustomizeGet()
        {
            InitializeComponent();
        }
        #endregion

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            bool fileCopier = false;
            try
            {
                #region File Copier
                if (cbAdobeCC.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCAdobeCC);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.AdobeCC, limit, ServicesLogDirectory + LicenseManager.SLCAdobeCC + "\\");
                    fileCopier = true;
                }

                if (cbDataAccess.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCDataAccess);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.DataAccess, limit, ServicesLogDirectory + LicenseManager.SLCDataAccess + "\\");
                    fileCopier = true;
                }

                if (cbEventStore.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCEventStore);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.EventStore, limit, ServicesLogDirectory + LicenseManager.SLCEventStore + "\\");
                    fileCopier = true;
                }

                if (cbEventWarehouse.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCEventWarehouse);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.EventWarehouse, limit, ServicesLogDirectory + LicenseManager.SLCEventWarehouse + "\\");
                    fileCopier = true;
                }

                if (cbGenericSaaS.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCGenericSaaS);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.GenericSaaS, limit, ServicesLogDirectory + LicenseManager.SLCGenericSaaS + "\\");
                    fileCopier = true;
                }

                if (cbImportTool.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCImportTool);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.ImportTool, limit, ServicesLogDirectory + LicenseManager.SLCImportTool + "\\");
                    fileCopier = true;
                }

                if (cbInventoryService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCInventoryAPI);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.InventoryService, limit, ServicesLogDirectory + LicenseManager.SLCInventoryAPI + "\\");
                    fileCopier = true;
                }

                if (cbComplianceService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCCompliance);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.Compliance, limit, ServicesLogDirectory + LicenseManager.SLCCompliance + "\\");
                    fileCopier = true;
                }

                if (cbLicensing.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCLicensing);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.Licensing, limit, ServicesLogDirectory + LicenseManager.SLCLicensing + "\\");
                    fileCopier = true;
                }

                if (cbLicensingService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCLicensingService);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.LicensingService, limit, ServicesLogDirectory + LicenseManager.SLCLicensingService + "\\");
                    fileCopier = true;
                }

                if (cbMaintenance.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCMaintenance);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.MaintenanceService, limit, ServicesLogDirectory + LicenseManager.SLCMaintenance + "\\");
                    fileCopier = true;
                }

                if (cbNotificationService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCNotification);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.NotificationDelivery, limit, ServicesLogDirectory + LicenseManager.SLCNotification + "\\");
                    fileCopier = true;
                }

                if (cbOffice365.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCOffice365);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.Office365, limit, ServicesLogDirectory + LicenseManager.SLCOffice365 + "\\");
                    fileCopier = true;
                }

                if (cbOracleManagement.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCOMO);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.OracleManagement, limit, ServicesLogDirectory + LicenseManager.SLCOMO + "\\");
                    fileCopier = true;
                }

                if (cbReportExport.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCReportExport);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.ReportExport, limit, ServicesLogDirectory + LicenseManager.SLCReportExport + "\\");
                    fileCopier = true;
                }

                if (cbSlmImport.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCSlmImport);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.SlmImport, limit, ServicesLogDirectory + LicenseManager.SLCSlmImport + "\\");
                    fileCopier = true;
                }

                if (cbEnterpriseAgreement.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCSEAS);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.SoftwareEnterpriseAgreement, limit, ServicesLogDirectory + LicenseManager.SLCSEAS + "\\");
                    fileCopier = true;
                }

                if (cbVirtualizationService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCVirtualization);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.Virtualization, limit, ServicesLogDirectory + LicenseManager.SLCVirtualization + "\\");

                    fileCopier = true;
                }

                if (cbUpdateService.Checked)
                {
                    Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCUpdateService);
                    Global.LogFileCopier(SlmServerPath + LicenseManager.UpdateService, limit, ServicesLogDirectory + LicenseManager.SLCUpdateService + "\\");
                    fileCopier = true;
                }
                #endregion

                if (fileCopier == true)
                {
                    MessageBox.Show("Logs have been copied.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("No checkboxes selected, please try again.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cbComplianceService_CheckedChanged(object sender, EventArgs e)
        {
            if(cbComplianceService.Checked)
            {
                MessageBox.Show("Please note that the Compliance Service directory is only present in Snow License Manager 7.  If it is not found, it will be skipped.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is CheckBox box)
                {
                    box.Checked = false;
                }
            }
            MessageBox.Show("Checkboxes cleared", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
