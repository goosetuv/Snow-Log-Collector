using System.IO;
using System.Linq;

namespace SLC
{
    public class LicenseManager
    {
        #region Fields
        #region SLM: Web Logs
        public static string Application = @"$\Program Files\Snow Software\Snow License Manager\Web\Logs\Application\";
        public static string Error = @"$\Program Files\Snow Software\Snow License Manager\Web\Logs\Error\";
        public static string WebAPI = @"$\Program Files\Snow Software\Snow License Manager\Web\Logs\WebApi\";
        public static string Security = @"$\Program Files\Snow Software\Snow License Manager\Web\Logs\Security\";
        #endregion

        #region SLM: Services Logs
        // These are the UNP Paths to the Snow Software Logs specifically.
        public static string MasterLogPath = @"$\Program Files\Snow Software\Logs\";

        public static string AdobeCC = MasterLogPath + @"AdobeCC\";
        public static string EventStore = MasterLogPath + @"EventStoreService\";
        public static string ImportTool = MasterLogPath + @"ImportTool\ImportTool_\";
        public static string InventoryService = MasterLogPath + @"InventoryService\";
        public static string NotificationDelivery = MasterLogPath + @"NotificationDelivery\";
        public static string Office365 = MasterLogPath + @"Office365Service\";
        public static string ReportExport = MasterLogPath + @"ReportExport\";
        public static string Compliance = MasterLogPath + @"Compliance\";
        public static string LicensingService = MasterLogPath + @"LicensingService\";
        public static string Licensing = MasterLogPath + @"Licensing\";
        public static string DataAccess = MasterLogPath + @"DataAccessService\";
        public static string EventWarehouse = MasterLogPath + @"EventWarehouse\";
        public static string GenericSaaS = MasterLogPath + @"GenericSaaS\";
        public static string MaintenanceService = MasterLogPath + @"Maintenance\";
        public static string OracleManagement = MasterLogPath + @"OracleManagementOption\";
        public static string SlmImport = MasterLogPath + @"SlmImport\";
        public static string SoftwareEnterpriseAgreement = MasterLogPath + @"SoftwareEnterpriseAgreementService\";
        public static string Virtualization = MasterLogPath + @"VirtualizationService\";
        public static string UpdateService = MasterLogPath + @"UpdateService\";
        #endregion

        #region SLC: Directory Names

        // These are the directories that SLC uses to copy the files from the SLM Logs
        // These can be anything, as they're unrelated to the snow products specifically.

        public static string SLCApplication = "Application";
        public static string SLCSecurity = "Security";
        public static string SLCError = "Error";
        public static string SLCWebAPI = "WebAPI";

        public static string SLCAdobeCC = "Adobe Creative Cloud";
        public static string SLCEventStore = "Event Store";
        public static string SLCImportTool = "ImportTool";
        public static string SLCInventoryAPI = "InventoryAPI";
        public static string SLCNotification = "Notification Delivery";
        public static string SLCOffice365 = "Office 365";
        public static string SLCReportExport = "Report Export";
        public static string SLCCompliance = "Compliance";
        public static string SLCLicensingService = "Licensing Service";
        public static string SLCLicensing = "Licensing";
        public static string SLCDataAccess = "Data Access Service";
        public static string SLCEventWarehouse = "Event Warehouse";
        public static string SLCGenericSaaS = "Generic SaaS";
        public static string SLCMaintenance = "Maintenance";
        public static string SLCOMO = "Oracle Management Option";
        public static string SLCSlmImport = "Slm Import";
        public static string SLCSEAS = "Software Enterprise Agreement Service";
        public static string SLCVirtualization = "Virtualization";
        public static string SLCUpdateService = "Update Service";

        #endregion
        #endregion

        #region Functions
        public static void WebDirectoryCreator(string WebLogDirectory)
        {
            if(Directory.Exists(WebLogDirectory) == false)
            {
                Directory.CreateDirectory(WebLogDirectory);
                Directory.CreateDirectory(WebLogDirectory + SLCApplication);
                Directory.CreateDirectory(WebLogDirectory + SLCError);
                Directory.CreateDirectory(WebLogDirectory + SLCSecurity);
                Directory.CreateDirectory(WebLogDirectory + SLCWebAPI);
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
