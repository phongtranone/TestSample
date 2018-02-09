using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace testSampleOne
{
    class FirstTestCase
    {
        IWebDriver driver;

        public bool CheckVisibleElement(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }


        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver(@"D:\\driver");
            

        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://siteone61.siteoneservices.net/account/login";
            driver.Manage().Window.Maximize();

            IWebElement username = driver.FindElement(By.Id("Email"));
            IWebElement password = driver.FindElement(By.Id("Password"));

            username.SendKeys("siteone61@yopmail.com");
            password.SendKeys("1234");


            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));
            rememberMe.Click();

            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@value='Sign in']"));
            loginBtn.Click();

            //Verify login success
            IWebElement profileLink = driver.FindElement(By.XPath("//a[text()='  My profile']"));
            if (CheckVisibleElement(profileLink))
            {
                Console.WriteLine("Login success");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Login fail");

            }
            
        }

        [TearDown]
        public void EndTest()
        {
            //driver.Close();
        }
    }
}
