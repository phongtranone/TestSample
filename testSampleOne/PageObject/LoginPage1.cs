using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    public class LoginPage1
    {
        public XmlSerializer serializer;
        public LoginElements11 loginElements;
        public string xmlFilePath = "LocationElements\\Login.xml";

        public LoginPage1()
        {
            serializer = new XmlSerializer(typeof(LoginElements11));
            loginElements = (LoginElements11)serializer.Deserialize(XmlReader.Create(xmlFilePath));
        }

        public By GetUsername()
        {
            switch (loginElements.Username.Name)
            {
                case "id":
                    return By.Id(loginElements.Username.Value);
                case "xpath":
                    return By.XPath(loginElements.Username.Value);
                default:
                    return null;
            }
        }

        public By GetPassword()
        {
            switch (loginElements.Password.Name)
            {
                case "id":
                    return By.Id(loginElements.Password.Value);
                case "xpath":
                    return By.XPath(loginElements.Password.Value);
                default:
                    return null;
            }
        }

        public By GetRememberMe()
        {
            switch (loginElements.RememberMe.Name)
            {
                case "id":
                    return By.Id(loginElements.RememberMe.Value);
                case "xpath":
                    return By.XPath(loginElements.RememberMe.Value);
                default:
                    return null;
            }
        }

        public By GetLoginButton()
        {
            switch (loginElements.LoginButton.Name)
            {
                case "id":
                    return By.Id(loginElements.LoginButton.Value);
                case "xpath":
                    return By.XPath(loginElements.LoginButton.Value);
                default:
                    return null;
            }
        }


        public void Login(IWebDriver driver)
        {
            IWebElement username = driver.FindElement(this.GetUsername());
            IWebElement password = driver.FindElement(this.GetPassword());

            username.SendKeys("siteone21@yopmail.com");
            password.SendKeys("1234");


            IWebElement rememberMe = driver.FindElement(this.GetRememberMe());
            rememberMe.Click();

            IWebElement loginBtn = driver.FindElement(this.GetLoginButton());
            loginBtn.Click();
        }
    }
}
