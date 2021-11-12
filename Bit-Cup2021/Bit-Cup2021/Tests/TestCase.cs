using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace Bit_Cup2021
{
    public class TestCase
    {
        private const string GoogleCalculator = "Google Cloud Platform Pricing Calculator";

        [SetUp]
        public void BeforeTest()
        {
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.GoTo(ConfigData.GoogleCloudUrl);
        }

        [Test]
        public static void Test()
        {
            var mainForm = Bit_CupTestSteps.CreateAndWaitForFormDisplayed<GoogleCloudMainForm>();
            mainForm.Search(GoogleCalculator);
            var searchForm = Bit_CupTestSteps.CreateAndWaitForFormDisplayed<GoogleCloudSearchForm>();
            searchForm.GoToGoogleCalculator();
            var calculatorForm = Bit_CupTestSteps.CreateAndWaitForFormDisplayed<GoogleCloudCalculatorForm>();
            calculatorForm.SwitchToMyFrame();
            calculatorForm.ClickComputeEngineLabel();
            calculatorForm.EnterNumberOfInstances(TestData.NumberOfInstances);
            calculatorForm.ClickOperatingSystemSoftwareLabel();
            Assert.IsTrue(calculatorForm.IsOperatingSystemSoftwareOptionExist(TestData.OperatingSystemSoftware), $"{TestData.OperatingSystemSoftware} option is not exist");
            calculatorForm.ClickOperatingSystemSoftwareOptionLabel(TestData.OperatingSystemSoftware);
            calculatorForm.ClickMachineClassLabel();
            Assert.IsTrue(calculatorForm.IsMachineClassOptionExist(TestData.MachineClass), $"{TestData.MachineClass} option is not exist");
            calculatorForm.ClickMachineClassOptionLabel(TestData.MachineClass);
            calculatorForm.ClickMachineTypeLabel();
            Assert.IsTrue(calculatorForm.IsMachineTypeOptionExist(TestData.MachineType), $"{TestData.MachineType} option is not exist");
            calculatorForm.ClickMachineTypeOptionLabel(TestData.MachineType);
            calculatorForm.ClickAddToEstimateInstancesButton();
            calculatorForm.EnterNumberOfNodes(TestData.NumberOfNodes);
            calculatorForm.CheckAddGPUsCheckBox();
            calculatorForm.ClickNumberOfGPUsLabel();
            Assert.IsTrue(calculatorForm.IsNumberOfGPUsOptionExist(TestData.NumberOfGPUs), $"{TestData.NumberOfGPUs} option is not exist");
            calculatorForm.ClickNumberOfGPUsOptionLabel(TestData.NumberOfGPUs);
            calculatorForm.ClickGPUTypeLabel();
            Assert.IsTrue(calculatorForm.IsGPUTypeOptionExist(TestData.GPUType), $"{TestData.GPUType} option is not exist");
            calculatorForm.ClickGPUTypeOptionLabel(TestData.GPUType);
            calculatorForm.ClickLocalSSDLabel();
            Assert.IsTrue(calculatorForm.IsLocalSSDOptionExist(TestData.LocalSSD), $"{TestData.LocalSSD} option is not exist");
            calculatorForm.ClickLocalSSDOptionLabel(TestData.LocalSSD);
            calculatorForm.ClickDatacenterLocationLabel();
            Assert.IsTrue(calculatorForm.IsDatacenterLocationOptionExist(TestData.DatacenterLocation), $"{TestData.DatacenterLocation} option is not exist");
            calculatorForm.ClickDatacenterLocationOptionLabel(TestData.DatacenterLocation);
            calculatorForm.ClickCommitedUsageLabel();
            Assert.IsTrue(calculatorForm.IsCommitedUsageOptionExist(TestData.CommitedUsage), $"{TestData.CommitedUsage} option is not exist");
            calculatorForm.ClickCommitedUsageOptionLabel(TestData.CommitedUsage);
            calculatorForm.ClickAddToEstimateSoleTenantNodesButton();
            calculatorForm.ClickEmailEstimateButton();

            System.Diagnostics.Debugger.Launch();
        }

        [TearDown]
        public void AfterTest()
        {
            if (AqualityServices.IsBrowserStarted)
            {
                AqualityServices.Browser.Quit();
            }
        }
    }
}