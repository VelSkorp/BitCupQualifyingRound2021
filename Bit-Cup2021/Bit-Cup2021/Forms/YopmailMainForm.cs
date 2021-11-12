using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Bit_Cup2021
{
    public class YopmailMainForm : Form
    {
        private ILink EmailGeneratorLink => ElementFactory.GetLink(By.XPath("//a[@class='hlink' and @href='email-generator']"), "Email generator link");

        public YopmailMainForm()
            : base(By.XPath("//div[@class='ycol1']"), "Yopmail main form")
        {
        }

        public void GoToEmailGenerator()
        {
            EmailGeneratorLink.Click();
        }
    }
}