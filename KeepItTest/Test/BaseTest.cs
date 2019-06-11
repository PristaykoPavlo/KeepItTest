
using KeepItTest.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItTest.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        protected static WebDriverWait Wait;

        protected static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }
                return driver;
            }
            set{}
        }
    }
}
