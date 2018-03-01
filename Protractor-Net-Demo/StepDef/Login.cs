using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor_Net_Demo.PageObj;
using Protractor_Net_Demo.Pages;
using TechTalk.SpecFlow;
using static Protractor_Net_Demo.CommonStep.Page;

namespace Protractor_Net_Demo.StepDef
{
    [Binding]
    public class SimpleMathSteps
    {

        //IWebDriver driver;
        LoginPage loginPage;

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            loginPage = new LoginPage();
            var readMe = "Hey";
            //Use of storing value from a step using ScenarioContext
            ScenarioContext.Current["ReadMe"] = readMe;

            //Use of storing value from a step using FeatureContext
            FeatureContext.Current["ReadMe"] = readMe;
            GoToHomePage();          
        }

        [Given(@"I click on Hide button")]
        public void GivenIClickOnHideButton()
        {
        }

        [Given(@"I click on ""(.*)"" content link")]
        public void GivenIClickOnContentLink(string textToClick)
        {
            loginPage.ClickOnContent(textToClick);
        }

        [Given(@"I click on test")]
        public void GivenIClickOnTest()
        {
            loginPage.ClickTest();
        }



        [Given(@"I click on Login link")]
        public void GivenIClickOnLoginLink()
        {
            loginPage.LogInClick();
        }


        [Given(@"I type username of (.*)")]
        public void GivenIEnterUsername(string username)
        {
            loginPage.EnterUserName(username);
        }

        [Given(@"I type password of (.*)")]
        public void GivenITypePasswordOfPassword(string password)
        {

            loginPage.EnterPassword(password);
            var scenarioContextValue = ScenarioContext.Current["ReadMe"];
            var featureContextValue = FeatureContext.Current["ReadMe"];
          
        }


        [Given(@"I read data")]
        public void GivenIReadData()
        {
            var featureContextValue = FeatureContext.Current["ReadMe"];
            var scenarioContextValue = ScenarioContext.Current["ReadMe"];

        }






        //[Given(@"I have a new calculator")]
        //public void GivenIHaveANewCalculator()
        //{
        //    driver = _ngDriver;
        //    normaldriver.Navigate().GoToUrl(URL);
        //    //page = new SuperCalculatorPage(driver, URL);
        //}


        //[After]
        //public void Teardown()
        //{
        //    driver.Quit();
        //}

    }
}
