using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Bit_Cup2021
{
	public class GoogleCloudSearchForm : Form
	{
		private ILink GoogleCalculatorLink => ElementFactory.GetLink(By.LinkText("Google Cloud Platform Pricing Calculator"), "Google calculator link");

		public GoogleCloudSearchForm()
			: base(By.XPath("//div[@class='devsite-cse-results']"), "Google cloud search form")
		{
		}

		public void GoToGoogleCalculator()
		{
			GoogleCalculatorLink.Click();
		}
	}
}