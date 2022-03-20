using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace SnowLogCollector.Classes
{
    public static class ConfigManager
    {
        private static readonly byte[] additionalEntropy = { 127, 126, 125, 124, 123 };

        // https://stackoverflow.com/a/37952523/12954031
        public static void AppSettingsSet(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var entry = config.AppSettings.Settings[key];
            if (entry == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }

            config.Save(ConfigurationSaveMode.Minimal);
        }

        public static string AppSettingsGet(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var entry = config.AppSettings.Settings[key].Value;

            return entry.ToString();
        }

        public static string ConnectionGet(string key = "SnowLogCollector")
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(
                    Convert.FromBase64String(
                        ConfigurationManager.ConnectionStrings[key].ConnectionString),
                    additionalEntropy, 
                    DataProtectionScope.CurrentUser)
                );
        }

        public static void ConnectionSet(string value, string key = "SnowLogCollector")
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(value), additionalEntropy, DataProtectionScope.CurrentUser));

            config.Save(ConfigurationSaveMode.Minimal);

        }

    }
}
