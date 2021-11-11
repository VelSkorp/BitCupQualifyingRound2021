using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Aquality.Selenium.Elements.Actions;

namespace Bit_Cup2021
{
    public class GoogleCloudMainForm : Form
    {
        private ITextBox Searchbox => ElementFactory.GetTextBox(By.XPath("//input[@class='devsite-search-field devsite-search-query']"), "Save project button");

        public GoogleCloudMainForm()
            : base(By.XPath("//div[@class='cloud-home']"), "Google cloud main form")
        {
        }

        public void Search(string value)
        {
            Searchbox.ClearAndType(value);
            Searchbox.SendKey(Key.Enter);
        }
    }
}