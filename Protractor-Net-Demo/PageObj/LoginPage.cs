using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using Protractor_Net_Demo.CommonStep;
using Protractor_Net_Demo.Pages;
using static Protractor_Net_Demo.CommonStep.CommonFunctions;

namespace Protractor_Net_Demo.PageObj
{
    public class LoginPage : Base
    {
        public LoginPage()
        {
            //normaldriver.Navigate().GoToUrl("https://www.aiglife.co.uk");
            //normaldriver
            PageFactory.InitElements(_ngDriver, this);
        }


        #region pageObj

        [FindsBy(How = How.XPath, Using = "(//ul[@class='nav-external']//a)[1]")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "FortisLogin_UserName")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "FortisLogin_Password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "item in $ctrl.items")]
        public IList<IWebElement> Contents { get; set; }
        //NgByBinding NgByBinding NgByExactBinding NgByExactRepeater NgByModel NgBySelectedOption
        //toc-container div.ng-scope

        [FindsBy(How = How.CssSelector, Using = "h2#-link-ng-ng-core-module-")]
       public IWebElement Ng { get; set; }

        #endregion


        public void LogInClick()
        {
            CommonActions("click", LoginLink, string.Empty);
        }

        public void EnterUserName(string username)
        {
            //UserNameField.Clear();
            //UserNameField.SendKeys(username);
            CommonActions("type", UserNameField, username);
        }

        public void EnterPassword(string password)
        {
            //PasswordField.Clear();
            //PasswordField.SendKeys(password);
            CommonActions("type", PasswordField, password);
        }

        public void ClickTest()
        {
            Ng.Click();
        }



        public void ClickOnContent(string content)
        {
            // HideButton.Click();
            //var getList = Contents.ToList();
            foreach (var contenttext in Contents.ToList())
            {
                if (contenttext.Text.Equals(content))
                {
                    contenttext.Click();
                    break;
                }

            }
        }
    }
}
