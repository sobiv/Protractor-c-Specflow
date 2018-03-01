using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace Protractor_Net_Demo.Pages
{
    [Binding]
    public class Base
    { 
        public static NgWebDriver _ngDriver;
        public static IWebDriver normaldriver;

        [BeforeTestRun]
        public static void FixtureTestSetup()
        {
            normaldriver = new ChromeDriver();
            //normaldriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            _ngDriver = new NgWebDriver(normaldriver);
        }

        [AfterTestRun]
        public static void FixtureTestTearDown()
        {
            _ngDriver.Quit();

        }
    }
}
