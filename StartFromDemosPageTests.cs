using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SDET_tests
{
    [TestFixture]
    public class StartFromDemosPageTests : ReportsGenerationClass
    {
        DemosPageObject demos;

        private void SetDemosPageObject()
        {
            demos = new DemosPageObject(_driver, _wait, _waitUntil, URL);
        }

        [Test]
        public void DemosPageLeftMenuBarContainsWidgetsTest()
        {
            SetDemosPageObject();
            _waitUntil.WaitForPageLoad();
            Assert.IsTrue(demos.DemosPageLeftMenuBarContainsWidgets());
        }

        [Test]
        public void PopupContainsInputNumberTest()
        {
            SetDemosPageObject();
            SpinnerPageObject spinnerPageObject = demos.GetSpinnerPageObject();
            _waitUntil.WaitForPageLoad();
            int number = 123;
            string content = number.ToString();
            Assert.IsTrue(spinnerPageObject.PopupContainsInputString(content));
        }

        [Test]
        public void TagsInputEqualsStrTest()
        {
            SetDemosPageObject();
            AutocompetePageObject autocompletePageObject = demos.GetAutocompiltePageObject();
            _waitUntil.WaitForPageLoad();
            string str = "Asp";
            string partialText = "a";
            Assert.IsTrue(autocompletePageObject.TagsInputEqualsStr(str, partialText));
        }
    }
}