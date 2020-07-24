using System;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SLC
{
    public class Inventory
    {
        #region Fields
        #region Inventory: Logs
        public static string InventoryServerLog = @"$\ProgramData\SnowSoftware\Inventory\Server\";
        public static string InventoryServerService = @"$\ProgramData\SnowSoftware\Inventory\ServerManager\";
        public static string InventoryUpdateService = @"$\Program Files\Snow Software\Logs\UpdateService\";
        #endregion

        #region SLC: Directory Names

        // These are the directories that SLC uses to copy the files from the SLM Logs
        // These can be anything, as they're unrelated to the snow products specifically.

        public static string SLCServerLogs = "Server";
        public static string SLCServerManagerLogs = "Server Manager";
        public static string SLCInventoryUpdate = "Update Service";
        #endregion

        #endregion

        #region Functions
        public static bool PingDevice(string HostName)
        {

            try
            {
                Ping p = new Ping();
                if (p.Send(HostName, 200).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static string ConvertDirectory(string Directory, string HostName)
        {
            FileInfo f = new FileInfo(Directory);
            string drive = Path.GetPathRoot(f.FullName);
            string driverLetter = drive.Replace(":\\", "");
            return Directory.Replace(drive, "\\\\" + HostName + "\\" + driverLetter + "$\\");
        }

        public static string GetSysInfo(string HostName, string win32Type, string username = "", string password = "", bool useCredentials = false)
        {
            try
            {
                ManagementObjectSearcher query = null;
                ManagementObjectCollection queryCollection = null;

                ConnectionOptions opt = new ConnectionOptions
                {
                    Impersonation = ImpersonationLevel.Impersonate,
                    Authentication = AuthenticationLevel.Packet,
                    EnablePrivileges = true
                };

                if(useCredentials == true)
                {
                    opt.Username = username;
                    opt.Password = password;
                }

                ManagementPath mp = new ManagementPath
                {
                    NamespacePath = @"\root\cimv2",
                    Server = HostName
                };

                ManagementScope msc = new ManagementScope(mp, opt);

                SelectQuery q = new SelectQuery(win32Type); //Win32_Environment, Win32_Service

                query = new ManagementObjectSearcher(msc, q, null);
                queryCollection = query.Get();

                foreach (ManagementBaseObject envVar in queryCollection)
                {
                    if ((string)envVar["Name"] == "snow_agent")
                    {
                        return (string)envVar["VariableValue"];
                    } else if(envVar.GetPropertyValue("Name").ToString().ToLower().Contains("inventoryagent")) {
                        return envVar.GetPropertyValue("State").ToString();
                    }
                }
                return "";
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message, "ManagementException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message, "UnauthorizedAccess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
        }

        public static void InventoryDirectoryCreator(string InventoryDirectoryName)
        {
            if (Directory.Exists(InventoryDirectoryName) == false)
            {
                Directory.CreateDirectory(InventoryDirectoryName);
                Directory.CreateDirectory(InventoryDirectoryName + SLCServerLogs);
                Directory.CreateDirectory(InventoryDirectoryName + SLCServerManagerLogs);
                Directory.CreateDirectory(InventoryDirectoryName + SLCInventoryUpdate);
            }
        }

        #endregion
    }
}
