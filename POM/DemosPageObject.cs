using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SDET_tests.POM;

namespace SDET_tests
{
    class DemosPageObject : PageObject
    {
        private readonly By _leftMenuBar = By.Id("sidebar");
        private readonly By _widgetWidgets = By.XPath("//aside[2]");
        private readonly By _spinner = By.PartialLinkText("Spinner");
        private readonly By _autocomplete = By.PartialLinkText("Autocomplete");

        public DemosPageObject(IWebDriver webDriver, WebDriverWait wait, WaitUntil waitUntil, string url) : base(webDriver, wait, waitUntil, url) { }
        private bool LeftMenuBarContainsString(string content)
        {
            IWebElement element = webDriver.FindElement(_leftMenuBar);
            return element.Text.Contains(content);
        }

        public bool DemosPageLeftMenuBarContainsWidgets()
        {
            string[] content = { "Interactions", "Widgets", "Effects", "Utilities" };
            foreach (var str in content)
            {
                if (!LeftMenuBarContainsString(str))
                {
                    return false;
                }
            }
            return true;
        }

        public SpinnerPageObject GetSpinnerPageObject()
        {
            string spinnerUrl = "https://jqueryui.com/spinner/";
            IWebElement element = webDriver.FindElement(_leftMenuBar);
            element = element.FindElement(_widgetWidgets);
            element = element.FindElement(_spinner);
            element.Click();
            return new SpinnerPageObject(webDriver, wait, waitUntil, spinnerUrl);
        }

        public AutocompetePageObject GetAutocompiltePageObject()
        {
            string autocompeteUrl = "https://jqueryui.com/autocomplete/";
            IWebElement element = webDriver.FindElement(_leftMenuBar);
            element = element.FindElement(_widgetWidgets);
            element = element.FindElement(_autocomplete);
            element.Click();
            return new AutocompetePageObject(webDriver, wait, waitUntil, autocompeteUrl);
        }
    }
}
