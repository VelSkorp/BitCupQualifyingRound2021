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
            calculatorForm.ClickOperatingSystemSoftwareOptionLabel(TestData.OperatingSystemSoftware);
            calculatorForm.ClickMachineClassLabel();
            calculatorForm.ClickMachineClassLabelOptionLabel(TestData.MachineClass);
            calculatorForm.ClickMachineTypeLabel();
            calculatorForm.ClickMachineTypeLabelOptionLabel(TestData.MachineType);
            calculatorForm.ClickAddToEstimateInstancesButton();

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