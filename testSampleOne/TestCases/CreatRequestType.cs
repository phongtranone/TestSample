using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testSampleOne.TestCases
{
    public class CreateRequestType
    {
        Common common = new Common();

        private By RequestTypeMenu = By.XPath("//a[text()=' Request types']");
        private By NewBtn = By.XPath("//button[text()='New']");
        private By RequestType = By.XPath("//div/input[@placeholder='Request type']");
        private By DoneBtn = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Request type']]//button[text()='Done']");


        public CreateRequestType()
        {
            
        }

        public void RunTest()
        {
           

            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            // common.Login(common.UsernameLocator, common.UsernameValue, common.PasswordLocator, common.PasswordValue, common.RememberMeLocator, common.LoginBtnLocator);
           // common.Login();
            common.ClickOnElement(common.Hambuger);
            common.ClickOnElement(RequestTypeMenu);
            common.WaitLoad(2000);
            common.ClickOnElement(NewBtn);
            common.WaitLoad(2000);
            common.InputData(RequestType,"Request Type " + common.GetCurrentDate);
            common.ClickOnElement(DoneBtn);
            common.WaitLoad(5000);
            common.CloseBrowser();
        }

    }
}
