using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Actions;
using Newtonsoft.Json.Linq;

namespace Bit_Cup2021
{
	public class GoogleCloudCalculatorForm : Form
	{
		private static string FrameID => "myFrame";
		private ITextBox NumberOfInstancesTextBox => ElementFactory.GetTextBox(By.XPath("//input[@id='input_74']"), "Number of instances text box");
		private ILabel ComputeEngineLabel => ElementFactory.GetLabel(By.XPath("//md-pagination-wrapper//div[@class='tab-holder compute']"), "Compute engine label");
		private ILabel OperatingSystemSoftwareLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_87']"), "Operating system software label");
		private ILabel MachineClassLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_91']"), "Machine class label");
		private ILabel MachineTypeLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_101']"), "Machine type label");
		private IButton AddToEstimateInstancesButton => ElementFactory.GetButton(By.XPath("(//button[@aria-label='Add to Estimate'])[1]"), "Add to estimate instances button");

		public GoogleCloudCalculatorForm()
			: base(By.XPath("//iframe[@id='myFrame']"), "Google cloud calculator form")
		{
		}

		public void SwitchToMyFrame()
		{
			AqualityServices.Browser.Driver.SwitchTo().Frame(0);
			AqualityServices.Browser.Driver.SwitchTo().Frame(FrameID);
		}

		public void ClickComputeEngineLabel()
		{
			ComputeEngineLabel.Click();
		}

		public void EnterNumberOfInstances(int numberOfInstances)
		{
			NumberOfInstancesTextBox.ClearAndType(numberOfInstances.ToString());
		}

		public void ClickOperatingSystemSoftwareLabel()
		{
			OperatingSystemSoftwareLabel.Click();
		}

		public void ClickMachineClassLabel()
		{
			MachineClassLabel.Click();
		}

		public void ClickMachineTypeLabel()
		{
			MachineTypeLabel.Click();
		}

		public void ClickAddToEstimateInstancesButton()
		{
			AddToEstimateInstancesButton.Click();
		}

		public void ClickOperatingSystemSoftwareOptionLabel(string optionText)
		{
			GetOperatingSystemSoftwareOptionLabel(optionText).Click();
		}

		public void ClickMachineClassLabelOptionLabel(string optionText)
		{
			GetMachineClassLabelOptionLabel(optionText).Click();
		}

		public void ClickMachineTypeLabelOptionLabel(string optionText)
		{
			GetMachineTypeLabelOptionLabel(optionText).Click();
		}

		private ILabel GetOperatingSystemSoftwareOptionLabel(string optionText)
		{
			return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_88']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
		}

		private ILabel GetMachineClassLabelOptionLabel(string optionText)
		{
			return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_92']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
		}

		private ILabel GetMachineTypeLabelOptionLabel(string optionText)
		{
			return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_102']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
		}
	}
}