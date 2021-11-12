using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Bit_Cup2021
{
    public class YopmailMailBoxForm : Form
    {
        private static string FrameID => "ifmail";
        private IButton RefreshButton => ElementFactory.GetButton(By.XPath("//button[@id='refresh']"), "Refresh button");
        private ILabel TotalEstimatedMonthlyCostLabel => ElementFactory.GetLabel(By.XPath("(//table//td//h3)[2]"), "Total estimated monthly cost label");

        public YopmailMailBoxForm()
            : base(By.XPath("//div[@class='pagemarge']"), "Yopmail main form")
        {
        }

        public void RefreshMailBox()
        {
            RefreshButton.Click();
        }

        public void SwitchToEmailContent()
        {
            AqualityServices.Browser.Driver.SwitchTo().Frame(FrameID);
        }

        public string GetTotalEstimatedMonthlyCost()
        {
            return TotalEstimatedMonthlyCostLabel.Text;
        }
    }
}