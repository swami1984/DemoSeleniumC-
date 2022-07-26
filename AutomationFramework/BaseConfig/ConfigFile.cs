using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.BaseConfig
{
    public class ConfigFile
    {

        [SetUp]
        public static void Initilize()
        {
            DriverReference.driver = new ChromeDriver();  
            DriverReference.driver.Navigate().GoToUrl("http://www.facebook.com/home.php");
            DriverReference.driver.Manage().Window.Maximize();
            DriverReference.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [TearDown]
        public static void CloseTest()
        {
            DriverReference.driver.Close();

        }


    }
}
