using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework
{
    class HomePageFactory
    {

        public HomePageFactory()
        {
            PageFactory.InitElements(DriverReference.driver, this);
        }



        [FindsBy(How = How.XPath, Using = " //a[text()='Women' ]")]
        public IWebElement WomensLink { get; set; }


        public void NavigateWomensPage()
        {

            SetPropertyObject.Click(WomensLink);
            DriverReference.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
       
    }
}
