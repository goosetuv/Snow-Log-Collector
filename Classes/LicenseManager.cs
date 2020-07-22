using System.IO;
using System.Linq;

namespace SLC
{
    public class LicenseManager
    {
        #region Fields
        #region SLM: Web Logs
        public static string Application = "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Application\\";
        public static string Error = "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Error\\";
        public static string WebAPI = "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\WebApi\\";
        public static string Security = "$\\Program Files\\Snow Software\\Snow License Manager\\Web\\Logs\\Security\\";
        #endregion

        #region SLM: Services Logs
        // These are the UNP Paths to the Snow Software Logs specifically.
        public static string MasterLogPath = "$\\Program Files\\Snow Software\\Logs\\";

        public static string AdobeCC = MasterLogPath + "AdobeCC\\";
        public static string EventStore = MasterLogPath + "EventStoreService\\";
        public static string ImportTool = MasterLogPath + "ImportTool\\ImportTool_\\";
        public static string InventoryService = MasterLogPath + "InventoryService\\";
        public static string NotificationDelivery = MasterLogPath + "NotificationDelivery\\";
        public static string Office365 = MasterLogPath + "Office365Service\\";
        public static string ReportExport = MasterLogPath + "ReportExport\\";
        public static string Compliance = MasterLogPath + "Compliance\\";
        public static string LicensingService = MasterLogPath + "LicensingService\\";
        public static string Licensing = MasterLogPath + "Licensing\\";
        public static string DataAccess = MasterLogPath + "DataAccessService\\";
        public static string EventWarehouse = MasterLogPath + "EventWarehouse\\";
        public static string GenericSaaS = MasterLogPath + "GenericSaaS\\";
        public static string MaintenanceService = MasterLogPath + "Maintenance\\";
        public static string OracleManagement = MasterLogPath + "OracleManagementOption\\";
        public static string SlmImport = MasterLogPath + "SlmImport\\";
        public static string SoftwareEnterpriseAgreement = MasterLogPath + "SoftwareEnterpriseAgreementService\\";
        public static string Virtualization = MasterLogPath + "VirtualizationService\\";
        public static string UpdateService = MasterLogPath + "UpdateService\\";
        #endregion

        #region SLC: Directory Names

        // These are the directories that SLC uses to copy the files from the SLM Logs
        // These can be anything, as they're unrelated to the snow products specifically.

        public static string SLCApplication = "Application";
        public static string SLCSecurity = "Security";
        public static string SLCError = "Error";
        public static string SLCWebAPI = "WebAPI";

        public static string SLCAdobeCC = "AdobeCC";
        public static string SLCEventStore = "EventStoreService";
        public static string SLCImportTool = "ImportTool";
        public static string SLCInventoryAPI = "InventoryAPIService";
        public static string SLCNotification = "NotificationDelivery";
        public static string SLCOffice365 = "Office365Service";
        public static string SLCReportExport = "ReportExport";
        public static string SLCCompliance = "ComplianceService";
        public static string SLCLicensingService = "LicensingService";
        public static string SLCLicensing = "Licensing";
        public static string SLCDataAccess = "DataAccessService";
        public static string SLCEventWarehouse = "EventWarehouse";
        public static string SLCGenericSaaS = "GenericSaaS";
        public static string SLCMaintenance = "Maintenance";
        public static string SLCOMO = "OracleManagementOption";
        public static string SLCSlmImport = "SlmImport";
        public static string SLCSEAS = "SoftwareEnterpriseAgreementService";
        public static string SLCVirtualization = "VirtualizationService";
        public static string SLCUpdateService = "UpdateService";

        #endregion
        #endregion

        #region Functions
        public static void WebDirectoryCreator(string WebLogDirectory)
        {
            if(Directory.Exists(WebLogDirectory) == false)
            {
                Directory.CreateDirectory(WebLogDirectory);
                Directory.CreateDirectory(WebLogDirectory + "Application\\");
                Directory.CreateDirectory(WebLogDirectory + "Error\\");
                Directory.CreateDirectory(WebLogDirectory + "Security\\");
                Directory.CreateDirectory(WebLogDirectory + "WebAPI\\");
            }
        }

        public static void ServicesDirectoryCreator(string ServiceLogDirectory)
        {
            if (Directory.Exists(ServiceLogDirectory) == false)
            {
                Directory.CreateDirectory(ServiceLogDirectory);
                Directory.CreateDirectory(ServiceLogDirectory + SLCEventStore);
                Directory.CreateDirectory(ServiceLogDirectory + SLCImportTool);
                Directory.CreateDirectory(ServiceLogDirectory + SLCInventoryAPI);
                Directory.CreateDirectory(ServiceLogDirectory + SLCNotification);
                Directory.CreateDirectory(ServiceLogDirectory + SLCOffice365);
                Directory.CreateDirectory(ServiceLogDirectory + SLCReportExport);
                Directory.CreateDirectory(ServiceLogDirectory + SLCCompliance);
                Directory.CreateDirectory(ServiceLogDirectory + SLCLicensingService);
                Directory.CreateDirectory(ServiceLogDirectory + SLCLicensing);
                Directory.CreateDirectory(ServiceLogDirectory + SLCAdobeCC);
                Directory.CreateDirectory(ServiceLogDirectory + SLCDataAccess);
                Directory.CreateDirectory(ServiceLogDirectory + SLCEventWarehouse);
                Directory.CreateDirectory(ServiceLogDirectory + SLCGenericSaaS);
                Directory.CreateDirectory(ServiceLogDirectory + SLCMaintenance);
                Directory.CreateDirectory(ServiceLogDirectory + SLCOMO);
                Directory.CreateDirectory(ServiceLogDirectory + SLCSlmImport);
                Directory.CreateDirectory(ServiceLogDirectory + SLCSEAS);
                Directory.CreateDirectory(ServiceLogDirectory + SLCVirtualization);
                Directory.CreateDirectory(ServiceLogDirectory + SLCUpdateService);

            }
        }
        #endregion
    }
}
