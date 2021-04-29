using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_tests.POM
{
    public abstract class PageObject
    {
        protected IWebDriver webDriver;
        protected WebDriverWait wait;
        protected WaitUntil waitUntil;
        protected string url;

        public PageObject(IWebDriver webDriver, WebDriverWait wait, WaitUntil waitUntil, string url)
        {
            if (webDriver.Url != url)
            {
                webDriver.Navigate().GoToUrl(url);
            }
            this.url = url;
            this.webDriver = webDriver;
            this.wait = wait;
            this.waitUntil = waitUntil;
        }
    }
}
