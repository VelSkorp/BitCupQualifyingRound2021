using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Browsers;

namespace Bit_Cup2021
{
    public class GoogleCloudCalculatorForm : Form
    {
        private static string FrameID => "myFrame";
        private ITextBox NumberOfInstancesTextBox => ElementFactory.GetTextBox(By.XPath("//input[@id='input_74']"), "Number of instances text box");
        private ITextBox NumberOfNodesTextBox => ElementFactory.GetTextBox(By.XPath("//input[@id='input_120']"), "Number of nodes text box");
        private ITextBox EmailTextBox => ElementFactory.GetTextBox(By.XPath("//input[@type='email']"), "Email text box");
        private ILabel ComputeEngineLabel => ElementFactory.GetLabel(By.XPath("//md-pagination-wrapper//div[@class='tab-holder compute']"), "Compute engine label");
        private ILabel OperatingSystemSoftwareLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_87']"), "Operating system software label");
        private ILabel MachineClassLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_91']"), "Machine class label");
        private ILabel MachineTypeLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_101']"), "Machine type label");
        private ILabel NumberOfGPUsLabel => ElementFactory.GetLabel(By.XPath("//md-select[contains(@aria-label,'Number of GPUs:')]"), "Number of GPUs label");
        private ILabel GPUTypeLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_443']"), "GPU type label");
        private ILabel LocalSSDLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_133']"), "Local SSD label");
        private ILabel DatacenterLocationLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_136']"), "Datacenter location label");
        private ILabel CommitedUsageLabel => ElementFactory.GetLabel(By.XPath("//md-select[@id='select_141']"), "Commited usage label");
        private ILabel TotalEstimatedMonthlyCostLabel => ElementFactory.GetLabel(By.XPath("//h2[@class='md-title']//b[@class='ng-binding']"), "Total estimated monthly cost label");
        private IButton AddToEstimateInstancesButton => ElementFactory.GetButton(By.XPath("(//button[@aria-label='Add to Estimate'])[1]"), "Add to estimate instances button");
        private IButton AddToEstimateSoleTenantNodesButton => ElementFactory.GetButton(By.XPath("(//button[@aria-label='Add to Estimate'])[2]"), "Add to estimate sole tenant nodes button");
        private IButton EmailEstimateButton => ElementFactory.GetButton(By.XPath("//button[@id='email_quote']"), "Email estimate button");
        private IButton SendEmailButton => ElementFactory.GetButton(By.XPath("//button[@aria-label='Send Email']"), "Send email button");
        private ICheckBox AddGPUsCheckBox => ElementFactory.GetCheckBox(By.XPath("//md-checkbox[@aria-label='Add GPUs']"), "Add GPUs check box");

        public GoogleCloudCalculatorForm()
            : base(By.XPath("//iframe[@id='myFrame']"), "Google cloud calculator form")
        {
        }

        public void SwitchToMyFrame()
        {
            AqualityServices.Browser.Driver.SwitchTo().Frame(0);
            AqualityServices.Browser.Driver.SwitchTo().Frame(FrameID);
        }

        public void CheckAddGPUsCheckBox()
        {
            AddGPUsCheckBox.Check();
        }

        public void ClickComputeEngineLabel()
        {
            ComputeEngineLabel.Click();
        }

        public void EnterNumberOfInstances(int numberOfInstances)
        {
            NumberOfInstancesTextBox.ClearAndType(numberOfInstances.ToString());
        }

        public void EnterNumberOfNodes(int numberOfNodes)
        {
            NumberOfNodesTextBox.ClearAndType(numberOfNodes.ToString());
        }

        public void EnterEmail(string Email)
        {
            EmailTextBox.ClearAndType(Email);
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

        public void ClickNumberOfGPUsLabel()
        {
            NumberOfGPUsLabel.Click();
        }

        public void ClickGPUTypeLabel()
        {
            GPUTypeLabel.Click();
        }

        public void ClickLocalSSDLabel()
        {
            LocalSSDLabel.Click();
        }

        public void ClickDatacenterLocationLabel()
        {
            DatacenterLocationLabel.Click();
        }

        public void ClickCommitedUsageLabel()
        {
            CommitedUsageLabel.Click();
        }

        public void ClickAddToEstimateInstancesButton()
        {
            AddToEstimateInstancesButton.Click();
        }

        public void ClickAddToEstimateSoleTenantNodesButton()
        {
            AddToEstimateSoleTenantNodesButton.Click();
        }

        public void ClickEmailEstimateButton()
        {
            EmailEstimateButton.Click();
        }

        public void ClickSendEmailButton()
        {
            SendEmailButton.Click();
        }

        public bool IsOperatingSystemSoftwareOptionExist(string optionText)
        {
            return GetOperatingSystemSoftwareOptionLabel(optionText).State.IsExist;
        }

        public bool IsMachineClassOptionExist(string optionText)
        {
            return GetMachineClassOptionLabel(optionText).State.IsExist;
        }

        public bool IsMachineTypeOptionExist(string optionText)
        {
            return GetMachineTypeOptionLabel(optionText).State.IsExist;
        }

        public bool IsNumberOfGPUsOptionExist(string optionText)
        {
            return GetNumberOfGPUsOptionLabel(optionText).State.IsExist;
        }

        public bool IsGPUTypeOptionExist(string optionText)
        {
            return GetGPUTypeOptionLabel(optionText).State.IsExist;
        }

        public bool IsLocalSSDOptionExist(string optionText)
        {
            return GetLocalSSDOptionLabel(optionText).State.IsExist;
        }

        public bool IsDatacenterLocationOptionExist(string optionText)
        {
            return GetDatacenterLocationOptionLabel(optionText).State.IsExist;
        }

        public bool IsCommitedUsageOptionExist(string optionText)
        {
            return GetCommitedUsageOptionLabel(optionText).State.IsExist;
        }

        public void ClickOperatingSystemSoftwareOptionLabel(string optionText)
        {
            GetOperatingSystemSoftwareOptionLabel(optionText).Click();
        }

        public void ClickMachineClassOptionLabel(string optionText)
        {
            GetMachineClassOptionLabel(optionText).Click();
        }

        public void ClickMachineTypeOptionLabel(string optionText)
        {
            GetMachineTypeOptionLabel(optionText).Click();
        }

        public void ClickNumberOfGPUsOptionLabel(string optionText)
        {
            GetNumberOfGPUsOptionLabel(optionText).Click();
        }

        public void ClickGPUTypeOptionLabel(string optionText)
        {
            GetGPUTypeOptionLabel(optionText).Click();
        }

        public void ClickLocalSSDOptionLabel(string optionText)
        {
            GetLocalSSDOptionLabel(optionText).Click();
        }

        public void ClickDatacenterLocationOptionLabel(string optionText)
        {
            GetDatacenterLocationOptionLabel(optionText).Click();
        }

        public void ClickCommitedUsageOptionLabel(string optionText)
        {
            GetCommitedUsageOptionLabel(optionText).Click();
        }

        public string GetTotalEstimatedMonthlyCost()
        {
            return TotalEstimatedMonthlyCostLabel.Text;
        }

        private ILabel GetOperatingSystemSoftwareOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_88']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetMachineClassOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_92']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetMachineTypeOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_102']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetNumberOfGPUsOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_442']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetGPUTypeOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_444']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetLocalSSDOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_134']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetDatacenterLocationOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_137']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }

        private ILabel GetCommitedUsageOptionLabel(string optionText)
        {
            return ElementFactory.GetLabel(By.XPath($"//div[@id='select_container_142']//md-option/div[contains(text(),'{optionText}')]"), $"{optionText} label");
        }
    }
}