﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText

    }

    class DriverReference
    {
        public static IWebDriver driver { get; set; }
        

    }

}



    



