using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Bit_Cup2021
{
    public class YopmailEmailGeneratorForm : Form
    {
        private ILabel EmailLabel => ElementFactory.GetLabel(By.XPath("//div[@id='egen']"), "Email label");
        private IButton CheckMailButton => ElementFactory.GetButton(By.XPath("(//button[contains(@class,'egenbut')])[3]"), "Check mail button");

        public YopmailEmailGeneratorForm()
            : base(By.XPath("//div[@class='pagemarge']"), "Yopmail main form")
        {
        }

        public string GetEmailAdress()
        {
            return EmailLabel.Text;
        }

        public void GoToMailBox()
        {
            CheckMailButton.Click();
        }
    }
}