using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;

namespace AutomationFramework
{
     class LoginPageFactory
    {
        public LoginPageFactory()
        {
            PageFactory.InitElements(DriverReference.driver, this); 
        }




        [FindsBy(How = How.XPath, Using = "//input[@id ='email']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id ='pass']")]
        public IWebElement Pwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        public IWebElement submit { get; set; }


        //[FindsBy(How = How.XPath, Using = "//input[@id='user_login']")]
        //public IWebElement SiteUsername { get; set; }

        //[FindsBy(How = How.XPath, Using = "//a[text()='Log in' and @class='marketing-nav__item marketing-nav__item--primary']")]
        //public IWebElement SignLinkHomePage { get; set; }


        //[FindsBy(How = How.XPath, Using = "//a[text()='Contact us']")]
        //public IWebElement contact { get; set; }

        ////a[text()='Log in' and @class='marketing-nav__item marketing-nav__item--primary']

        public HomePageFactory LoginPage(string username,string password)
        {

            SetPropertyObject.SetValue(Email, username);
            SetPropertyObject.SetValue(Pwd, password);
            SetPropertyObject.Click(submit);


            DriverReference.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           

            return new HomePageFactory();

        }



    }







}
