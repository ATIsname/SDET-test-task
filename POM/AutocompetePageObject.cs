using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SDET_tests.POM;
using System.Threading;

namespace SDET_tests
{
    class AutocompetePageObject : PageObject
    {
        private readonly By _iframe = By.XPath("//*[@id='content']/iframe");
        private readonly By _tagTextInput = By.Id("tags");
        private readonly By _tagsList = By.Id("ui-id-1");

        public AutocompetePageObject(IWebDriver webDriver, WebDriverWait wait, WaitUntil waitUntil, string url) : base(webDriver, wait, waitUntil, url) { }

        public bool TagsInputEqualsStr(string str, string partialText)
        {
            waitUntil.WaitUntilFrameToBeAvailableAndSwitchToIt( _iframe);
            IWebElement tagTextInputElement = webDriver.FindElement(_tagTextInput);
            tagTextInputElement.SendKeys(partialText);
            waitUntil.WaitUntilVisibilityOfAllElementsLocatedByIsVisible(_tagsList);
            do
            {
                tagTextInputElement.SendKeys(Keys.ArrowDown);
                if (tagTextInputElement.GetAttribute("value") == str)
                {
                    tagTextInputElement.SendKeys(Keys.Enter);
                    return true;
                }
            } while (tagTextInputElement.GetAttribute("value") != partialText);
            tagTextInputElement.SendKeys(Keys.Enter);
            return false;
        }
    }
}
