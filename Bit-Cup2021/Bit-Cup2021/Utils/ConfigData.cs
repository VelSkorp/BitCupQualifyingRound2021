using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;

namespace Bit_Cup2021
{
    public static class ConfigData
    {
        public static string GoogleCloudUrl => ConfigFile.GetValue<string>("googleCloudUrl");
        public static string YopmailUrl => ConfigFile.GetValue<string>("yopmailUrl");
        private static ISettingsFile ConfigFile = new JsonSettingsFile("Config.json");
    }
}