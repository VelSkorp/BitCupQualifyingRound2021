using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;

namespace Bit_Cup2021
{
    public static class TestData
    {
        public static int NumberOfInstances => TestDataFile.GetValue<int>("instances.numberOfInstances");
        public static string OperatingSystemSoftware => TestDataFile.GetValue<string>("instances.operatingSystemSoftware");
        public static string MachineClass => TestDataFile.GetValue<string>("instances.machineClass");
        public static string MachineType => TestDataFile.GetValue<string>("instances.machineType");
        private static ISettingsFile TestDataFile = new JsonSettingsFile("TestData.json");
    }
}