using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Protractor_Net_Demo.CommonStep
{
    class CommonFunctions
    {

        public static void CommonActions(string typeOfAction, IWebElement element, string textToSend)

        {
            bool staleElement = true;
            while (staleElement)
            {
                try
                {
                    switch (typeOfAction)
                    {
                        case "click":
                            element.Click();
                            break;
                        case "type":
                            //element.Clear();
                            //element.SendKeys(textToSend);

                            SendKeyAction(element,textToSend);
                            break;
                    }
                    staleElement = false;

                }
                catch (StaleElementReferenceException e)
                    {
                        staleElement = true;
                    }
                }
            }

        public static void SendKeyAction(IWebElement element, string textToSend)
        {
            element.Click();
            element.SendKeys(textToSend);
        }

    }
    }