using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    public class LoginPage
    {
        string xmlFilePath = "LocationElements\\Login.xml";
        LoginElements loginElements;
        By username;
        By password;
        By rememberMe;
        By loginBtn;

        public LoginPage()
        {
            loginElements = new LoginElements(xmlFilePath);
            username = loginElements.GetUsername();
            password = loginElements.GetPassword();
            rememberMe = loginElements.GetRememberMe();
            loginBtn = loginElements.GetLoginButton();
        }


        public void Login(IWebDriver driver, string usernameData, string passwordData)
        {
            driver.FindElement(username).SendKeys(usernameData);
            driver.FindElement(password).SendKeys(passwordData);
            driver.FindElement(rememberMe).Click();
            driver.FindElement(loginBtn).Click();
        }
    }
}
