using Microsoft.Win32;
using System;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SLC
{
    public class Inventory
    {
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
                MessageBox.Show(ex.Message, "Uncaught Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public static string GetSysInfo(string HostName, string username = "", string password = "", bool useCredentials = false)
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

            
                ManagementPath mp = new ManagementPath();
                mp.NamespacePath = @"\root\cimv2";
                mp.Server = HostName;

                ManagementScope msc = new ManagementScope(mp, opt);

                SelectQuery q = new SelectQuery("Win32_Environment");

                query = new ManagementObjectSearcher(msc, q, null);
                queryCollection = query.Get();

                foreach (ManagementBaseObject envVar in queryCollection)
                {
                    if((string)envVar["Name"] == "snow_agent")
                    {
                        return (string)envVar["VariableValue"];
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
        #endregion
    }
}
