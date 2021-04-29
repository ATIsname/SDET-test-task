# SDET-test-task# SDET-test-task
The project automates next list of tests:

  Test 1 (DemosPageLeftMenuBarContainsWidgetsTest)
1. Navigate to https://jqueryui.com/demos
2. Verify left menu bar contains the following sections
● Interactions 
● Widgets
● Effects
● Utilities

  Test 2 (PopupContainsInputNumberTest)
1. Navigate to https://jqueryui.com/demos
2. Click "Spinner" link in "Widgets" left menu section
3. Enter any digital value In "Select a value" textbox
4. Click "Get value" button
5. Verify that appeared popup contains entered value


  Test 3 (TagsInputEqualsStrTest)
1. Navigate to https://jqueryui.com/demos
2. Click "Autocomplete" link in "Widgets" left menu section
3. Type “a” in Tags field
4. From the appeared autocomplete list select option with “Asp” value using keyboard
actions (“arrow down” and “enter”)
5. Verify Tags field value is Asp


Using:
Visual Studio 2019;
C# .Net 3.1;
chromedriver.exe (89.04389.2300).

NuGet packages:
Microsoft.NET.Test.Sdk(16.5.0);
NUnit(3.12.0);
NUnit3TestAdapter(3.16.1);
Selenium.Suppor(3.14.0)t;
Selenium.WebDriver(3.14.0);
Selenium.WebDriver.ChromeDriver(89.04389.2300);
DotNetSeleniumExtras.WaitHelpers(3.11.0);
ExtentReports(4.1.0).

The project contains:
● c# code;
● Test results report.

To see test result report - open Reports directory, download index.file and open it using your browser.

For other information contact: dan.lis.2016@mail.ru
