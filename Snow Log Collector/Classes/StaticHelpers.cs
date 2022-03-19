using System.Configuration;

namespace SnowLogCollector.Classes
{
    public static class StaticHelpers
    {
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

            config.Save(ConfigurationSaveMode.Modified);
        }

        public static string AppSettingsGet(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var entry = config.AppSettings.Settings[key];

            return entry.ToString();
        }

        public static string ConnectionGet(string key = "SnowLogCollector")
        {
           return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

    }
}
