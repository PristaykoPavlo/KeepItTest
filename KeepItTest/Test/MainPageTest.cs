using KeepItTest.Tests;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItTest.Test
{
    [TestFixture]
    class MainPageTest: BaseTest
    {
        const string login = "automation@keepitqa.com";
        const string pass = "E#*b2wGIbFHz";

        protected MainPage MainPage = new MainPage();//create instance of MainPage with all methods

        [OneTimeSetUp]
        public void TestInitialize()// here we initialize web elements in Page Object, set up 10sec for waiting on web elements
        {
            PageFactory.InitElements(Driver, MainPage);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        [OneTimeTearDown]// here we quit driver, close all Chrome windows
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void CreateOfficeAdmin_Test()
        {         
            //step 1-2
            MainPage.Login(login, pass);
            //step 3
            MainPage.ClickAddBtn().SelectOfficeAdmin();
            //step 4
            Assert.IsTrue(MainPage.IsFormContainsText(), "Step 4: Office 365 Admin doesn't create");
        }
    }
}
