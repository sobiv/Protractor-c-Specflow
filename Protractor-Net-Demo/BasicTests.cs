using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using FluentAssertions;

namespace Protractor_Net_Demo
{
    [TestFixture]
    public class BasicTests
    {
        const string URL = "http://juliemr.github.io/protractor-demo/";

        IWebDriver driver;
        NgWebDriver ngDriver;

        [SetUp]
        public void Setup()
        {
            driver  = new ChromeDriver();
            ngDriver = new NgWebDriver(driver);
        }

        [Test]
        public void Basic_Homepage_ShouldHaveATitle()
        {
            ngDriver.Url = URL;
            var title = ngDriver.Title;
            title.Should().Be("Super Calculator");
        }

        [Test]
        public void Basic_AddOneAndTwo_ShouldBeThree()
        {
            }

        [TearDown]
        public void Teardown()
        {
            ngDriver.Quit();
        }
    }
}
