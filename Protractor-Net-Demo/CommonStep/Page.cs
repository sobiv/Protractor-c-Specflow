using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using Protractor_Net_Demo.Pages;

namespace Protractor_Net_Demo.CommonStep
{
    class Page : Base
    {
        private const string BaseUrl = "https://docs.angularjs.org";
        //https://docs.angularjs.org
        //"https://www.aiglife.co.uk";

        public static void GoToHomePage()
        {
          //  normaldriver.Navigate().GoToUrl(BaseUrl);
            _ngDriver.Url = BaseUrl;
        }


    }
}
