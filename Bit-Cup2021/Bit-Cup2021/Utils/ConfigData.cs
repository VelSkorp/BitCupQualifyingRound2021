using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;

namespace Bit_Cup2021
{
    public static class ConfigData
    {
        public static string GoogleCloudUrl => TestDataFile.GetValue<string>("googleCloudUrl");
        public static string YopmailUrl => TestDataFile.GetValue<string>("yopmailUrl");
        private static ISettingsFile TestDataFile = new JsonSettingsFile("Config.json");
    }
}