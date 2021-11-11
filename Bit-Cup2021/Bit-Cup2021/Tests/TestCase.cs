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
            var googleCloudMainForm = Bit_CupTestSteps.CreateAndWaitForFormDisplayed<GoogleCloudMainForm>();
            googleCloudMainForm.Search(GoogleCalculator);
            var googleCloudSearchForm = Bit_CupTestSteps.CreateAndWaitForFormDisplayed<GoogleCloudSearchForm>();
            googleCloudSearchForm.GoToGoogleCalculator();
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