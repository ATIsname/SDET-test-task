using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_tests
{
    public class WaitUntil
    {
        private WebDriverWait wait;

        public WaitUntil(WebDriverWait wait)
        {
            this.wait = wait;
        }

        public void WaitForPageLoad()
        {
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void WaitUntilAlertIsPresent()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        }

        public void WaitUntilVisibilityOfAllElementsLocatedByIsVisible(By _tagsList)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(_tagsList));
        }

        public void WaitUntilFrameToBeAvailableAndSwitchToIt(By _iframe)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(_iframe));
        }
    }
}
