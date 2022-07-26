using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
     class SetPropertyObject
    {

        public static void SetValue(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        public static void SelectValue(IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }
          
        public static void Click(IWebElement element)
        {
            element.Click();    
        }


    }
}

