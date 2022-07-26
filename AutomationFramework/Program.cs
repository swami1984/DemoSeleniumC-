using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.BaseConfig;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CategoryAttribute = NUnit.Framework.CategoryAttribute;

namespace AutomationFramework 
{
    [TestFixture]
     public class FireFoxTesting : ConfigFile
    {
        
       
        
        static void Main(string[] args)
        {
        }

    
        [Test, Category("Test Release1")]
        public static void TestExecute1()
        {
            LoginPageFactory loginPageScreen = new LoginPageFactory();
            HomePageFactory HomePage = loginPageScreen.LoginPage("tswamy2009@gmail.com","qspider");

           // HomePage.NavigateWomensPage();
        }

        [Test, Category("Test Release2")]
        public static void TestExecute2()
        {
            LoginPageFactory loginPageScreen = new LoginPageFactory();
            HomePageFactory HomePage = loginPageScreen.LoginPage("tswamy2009@gmail.com", "qspider");

            // HomePage.NavigateWomensPage();
        }

        [Test, Category("Test Release3")]
        public static void TestExecute3()
        {
            LoginPageFactory loginPageScreen = new LoginPageFactory();
            HomePageFactory HomePage = loginPageScreen.LoginPage("tswamy2009@gmail.com", "qspider");

            // HomePage.NavigateWomensPage();
        }


        //[Test, Category("Build Release2")]
        //public static void TestExecute2()
        //{
        //    LoginPageFactory loginPageScreen = new LoginPageFactory();
        //    HomePageFactory HomePage = loginPageScreen.LoginPage();

        //    HomePage.NavigateWomensPage();
        //}



    }
}
