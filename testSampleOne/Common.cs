﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testSampleOne.PageObject;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne
{
    class Common
    {
        public IWebDriver driver;

        public XElement CommonElement;
        public XElement UsernameElement;
        public String BrowserName;
        public XElement login;
        public String Url;
        public String UsernameValue;
        public String PasswordValue;
        public LoginPageObject loginPage = new LoginPageObject();
        public BrowserEnum browser;

        public string Email { get; set; }


        public By UsernameLocator;

        public Common()
        {
            XDocument CommonsData = XDocument.Load("InputData\\CommonsData.xml");
            CommonElement = CommonsData.Element(XName.Get("Commons"));
            BrowserName = CommonElement.Element("Browser").Value;
            login = CommonElement.Element("Login");
            Url = login.Element("Url").Value;
            UsernameValue = login.Element("Email").Value;
            PasswordValue = login.Element("Password").Value;

            //XDocument LoginPage = XDocument.Load("LocationElements\\Login.xml");
            //var root = LoginPage.Root;

            //UsernameElement = root.Element("Username");
            //if (UsernameElement.Name == "id")
            //{
            //    UsernameLocator = By.Id(UsernameElement.Value);
            //}


            //loginPage = new LoginPage();
        }




        public By PasswordLocator = By.Id("Password");
        public By RememberMeLocator = By.Id("RememberMe");
        public By LoginBtnLocator = By.XPath("//input[@value='Sign in']");


        public By Hambuger = By.XPath("//span[@data-toggle='offcanvas']");
        public DateTime GetCurrentDate = DateTime.Now;

        public void OpenBrowser(String browserName)
        {
            if (string.Equals(BrowserName, "chrome", StringComparison.OrdinalIgnoreCase))
            {
                this.driver = new ChromeDriver("\\Driver");
                this.driver.Manage().Window.Maximize();
            }
        }

        public void OpenBrowser(BrowserEnum browser)
        {
            switch (browser)
            {
                default:
                    {
                        throw new InvalidOperationException(nameof(browser));
                    }

                case BrowserEnum.Chrome:
                    {
                        this.driver = new ChromeDriver("\\Driver");
                        this.driver.Manage().Window.Maximize();

                        break;
                    }

                case BrowserEnum.Firefox:
                    {
                        break;
                    }

                case BrowserEnum.InternetExplorer:
                    {
                        break;
                    }
            }
        }

        public void CloseBrowser()
        {
            this.driver.Close();
        }

        public void GoToUrl(String Url)
        {
            this.driver.Url = Url;
        }

        public void WaitLoad(int MiliSecond)
        {
            Thread.Sleep(MiliSecond);
        }

        public void ClickOnElement(By ElementLocator)
        {
            driver.FindElement(ElementLocator).Click();
        }

        public void InputData(By ElementLocator, String DataInput)
        {
            driver.FindElement(ElementLocator).SendKeys(DataInput);
        }

        

        //public void Login()
        //{
        //    loginPage.Login(driver);
        //}
    }

    public enum BrowserEnum
    {
        Chrome = 11,
        Firefox = 22,
        InternetExplorer = 33
    }

}
