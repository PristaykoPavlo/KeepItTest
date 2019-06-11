using KeepItTest.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeepItTest.Tests
{
    public class MainPage : BaseTest
    {
        #region WebElements
        /// <summary>SignIn button </summary>
        [FindsBy(How = How.Id, Using = "login-form-login-button")]
        public IWebElement SigInBtn;

        /// <summary>Email input on login page </summary>
        [FindsBy(How = How.Id, Using = "login-form-login")]
        public IWebElement EmailInput;

        /// <summary>Password input on login page </summary>
        [FindsBy(How = How.Id, Using = "login-form-password")]
        public IWebElement PasswordInput;

        /// <summary>Add button under cloud services </summary>
        [FindsBy(How = How.Id, Using = "cloud-devices-button")]
        public IWebElement AddBtn;

        /// <summary>Office Admin option in List </summary>
        [FindsBy(How = How.Id, Using = "o365_admin")]
        public IWebElement OfficeAdminOption;

        /// <summary>Device form with message </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='device-form']/div")]
        public IWebElement DeviceForm;
        #endregion

        #region Methods
        public MainPage ClickLoginBtn()
        {
            Thread.Sleep(1000);//added only for presentation video
            SigInBtn.Click();
            return this;
        }

        public MainPage SetLogin(string value)
        {
            Thread.Sleep(1000);//added only for presentation video
            EmailInput.SendKeys(value);
            return this;
        }
        public MainPage SetPassword(string value)
        {
            Thread.Sleep(1000);//added only for presentation video
            PasswordInput.SendKeys(value);
            return this;
        }

        public MainPage ClickAddBtn()
        {
            //wait for Add button to be enabled
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("cloud-devices-button")));
            Thread.Sleep(1000);//added only for presentation video
            AddBtn.Click();
            return this;
        }
        
        public MainPage SelectOfficeAdmin()
        {
            Thread.Sleep(2000);//added only for presentation video
            OfficeAdminOption.Click();
            return this;
        }
         
        public MainPage Login(string login, string password)
        {
            Driver.Navigate().GoToUrl("https://ws-test.keepit.com/signin.html");
            SetLogin(login).SetPassword(password).ClickLoginBtn();
            return this;
        }

        public bool IsFormContainsText()
        {
            Thread.Sleep(1500);//added only for presentation video
            Wait.Until(ExpectedConditions.TextToBePresentInElement(DeviceForm, "Create new Office 365 Connector"));
            return DeviceForm.Text == "Create new Office 365 Connector";
        }
        #endregion
    }
}
