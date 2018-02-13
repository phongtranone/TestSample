using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatNewMarket: ITestCase
    {
        Common common = new Common();
        RegionAndMarket RegionAndMarketPage = new RegionAndMarket();

        public CreatNewMarket()
        {
            
        }

        public void RunTest()
        {
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            //common.Login(common.UsernameLocator, common.UsernameValue, common.PasswordLocator, common.PasswordValue, common.RememberMeLocator, common.LoginBtnLocator);
            common.Login();
            common.ClickOnElement(common.Hambuger);
            //common.ClickOnElement(RegionAndMarketPage.GetRegionAndMarketMenu());
            //common.WaitLoad(2000);
            //common.ClickOnElement(RegionAndMarketPage.GetNewBtn());
            //common.ClickOnElement(RegionAndMarketPage.GetMarketItem());
            //common.WaitLoad(2000);
            //common.InputData(RegionAndMarketPage.GetMarketName(),"Market name " + common.GetCurrentDate);
            //common.InputData(RegionAndMarketPage.GetMarketDescription(), "Market description " + common.GetCurrentDate);
            //common.ClickOnElement(RegionAndMarketPage.GetDoneBtnMarket());
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
