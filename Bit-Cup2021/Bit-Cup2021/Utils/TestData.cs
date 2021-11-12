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
        public static int NumberOfNodes => TestDataFile.GetValue<int>("soleTenantNodes.numberOfNodes");
        public static string NumberOfGPUs => TestDataFile.GetValue<string>("soleTenantNodes.numberOfGPUs");
        public static string GPUType => TestDataFile.GetValue<string>("soleTenantNodes.gpuType");
        public static string LocalSSD => TestDataFile.GetValue<string>("soleTenantNodes.localSSD");
        public static string DatacenterLocation => TestDataFile.GetValue<string>("soleTenantNodes.datacenterLocation");
        public static string CommitedUsage => TestDataFile.GetValue<string>("soleTenantNodes.commitedUsage");
        private static ISettingsFile TestDataFile = new JsonSettingsFile("TestData.json");
    }
}