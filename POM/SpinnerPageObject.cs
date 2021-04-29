using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SDET_tests.POM;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_tests
{
    class SpinnerPageObject : PageObject
    {

        private readonly By _iframe = By.XPath("//*[@id='content']/iframe");
        private readonly By _spinnerTextInput = By.Id("spinner");
        private readonly By _getValueButton = By.Id("getvalue");

        public SpinnerPageObject(IWebDriver webDriver, WebDriverWait wait, WaitUntil waitUntil, string url) : base(webDriver, wait, waitUntil, url) { }

        public bool PopupContainsInputString(string content)
        {
            waitUntil.WaitUntilFrameToBeAvailableAndSwitchToIt(_iframe);
            webDriver.FindElement(_spinnerTextInput).SendKeys(content);
            webDriver.FindElement(_getValueButton).Click();
            waitUntil.WaitUntilAlertIsPresent();
            IAlert alert = webDriver.SwitchTo().Alert();
            bool state = alert.Text.Contains(content);
            alert.Accept();
            return state;
        }
    }
}
