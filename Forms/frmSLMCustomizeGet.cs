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

            if (cbAdobeCC.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCAdobeCC);
                Global.LogFileCopier(SlmServerPath + LicenseManager.AdobeCC, limit, ServicesLogDirectory + LicenseManager.SLCAdobeCC + "\\");
            }

            if(cbDataAccess.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCDataAccess);
                Global.LogFileCopier(SlmServerPath + LicenseManager.DataAccess, limit, ServicesLogDirectory + LicenseManager.SLCDataAccess + "\\");
            }

            if(cbEventStore.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCEventStore);
                Global.LogFileCopier(SlmServerPath + LicenseManager.EventStore, limit, ServicesLogDirectory + LicenseManager.SLCEventStore + "\\");
            }

            if (cbEventWarehouse.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCEventWarehouse);
                Global.LogFileCopier(SlmServerPath + LicenseManager.EventWarehouse, limit, ServicesLogDirectory + LicenseManager.SLCEventWarehouse + "\\");
            }

            if(cbGenericSaaS.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCGenericSaaS);
                Global.LogFileCopier(SlmServerPath + LicenseManager.GenericSaaS, limit, ServicesLogDirectory + LicenseManager.SLCGenericSaaS + "\\");
            }

            if(cbImportTool.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCImportTool);
                Global.LogFileCopier(SlmServerPath + LicenseManager.ImportTool, limit, ServicesLogDirectory + LicenseManager.SLCImportTool + "\\");
            }

            if(cbInventoryService.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCInventoryAPI);
                Global.LogFileCopier(SlmServerPath + LicenseManager.InventoryService, limit, ServicesLogDirectory + LicenseManager.SLCInventoryAPI + "\\");
            }

            if(cbComplianceService.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCCompliance);
                Global.LogFileCopier(SlmServerPath + LicenseManager.Compliance, limit, ServicesLogDirectory + LicenseManager.SLCCompliance + "\\");
            }

            if(cbLicensing.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCLicensing);
                Global.LogFileCopier(SlmServerPath + LicenseManager.Licensing, limit, ServicesLogDirectory + LicenseManager.SLCLicensing + "\\");
            }

            if(cbLicensingService.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCLicensingService);
                Global.LogFileCopier(SlmServerPath + LicenseManager.LicensingService, limit, ServicesLogDirectory + LicenseManager.SLCLicensingService + "\\");
            }

            if(cbMaintenance.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCMaintenance);
                Global.LogFileCopier(SlmServerPath + LicenseManager.MaintenanceService, limit, ServicesLogDirectory + LicenseManager.SLCMaintenance + "\\");
            }

            if(cbNotificationService.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCNotification);
                Global.LogFileCopier(SlmServerPath + LicenseManager.NotificationDelivery, limit, ServicesLogDirectory + LicenseManager.SLCNotification + "\\");
            }

            if(cbOffice365.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCOffice365);
                Global.LogFileCopier(SlmServerPath + LicenseManager.Office365, limit, ServicesLogDirectory + LicenseManager.SLCOffice365 + "\\");
            }

            if(cbOracleManagement.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCOMO);
                Global.LogFileCopier(SlmServerPath + LicenseManager.OracleManagement, limit, ServicesLogDirectory + LicenseManager.SLCOMO + "\\");
            }

            if(cbReportExport.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCReportExport);
                Global.LogFileCopier(SlmServerPath + LicenseManager.ReportExport, limit, ServicesLogDirectory + LicenseManager.SLCReportExport + "\\");
            }

            if(cbSlmImport.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCSlmImport);
                Global.LogFileCopier(SlmServerPath + LicenseManager.SlmImport, limit, ServicesLogDirectory + LicenseManager.SLCSlmImport + "\\");
            }

            if(cbEnterpriseAgreement.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCSEAS);
                Global.LogFileCopier(SlmServerPath + LicenseManager.SoftwareEnterpriseAgreement, limit, ServicesLogDirectory + LicenseManager.SLCSEAS + "\\");
            }

            if(cbVirtualizationService.Checked)
            {
                Directory.CreateDirectory(ServicesLogDirectory + LicenseManager.SLCVirtualization);
                Global.LogFileCopier(SlmServerPath + LicenseManager.Virtualization, limit, ServicesLogDirectory + LicenseManager.SLCVirtualization + "\\");

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
                if(control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
    }
}
