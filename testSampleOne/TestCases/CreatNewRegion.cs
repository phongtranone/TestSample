using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatNewRegion
    {
        Common common;
        LoginPageObject loginPage;
        HomePageObject homePage;
        RegionAndMarketPageObject regionAndMarketPageObject;

        public CreatNewRegion()
        {
            common = new Common();
            loginPage = new LoginPageObject();
            homePage = new HomePageObject();
            regionAndMarketPageObject = new RegionAndMarketPageObject();
        }

        public void RunTest()
        {
            common.OpenBrowser(common.BrowserName);
            common.GoToUrl(common.Url);
            loginPage.Login(common.driver, "siteone21@yopmail.com","1234");
            common.WaitLoad(2000);
            common.ClickOnElement(homePage.HamburgerMenuIcon);
            common.ClickOnElement(homePage.RegionAndMarketsMenu);
            common.WaitLoad(2000);
            common.ClickOnElement(regionAndMarketPageObject.NewBtn);
            common.ClickOnElement(regionAndMarketPageObject.RegionItem);
            common.WaitLoad(2000);
            common.InputData(regionAndMarketPageObject.RegionName,"Region name " + common.GetCurrentDate);
            common.WaitLoad(2000);
            common.InputData(regionAndMarketPageObject.RegionDescription, "Region description " + common.GetCurrentDate);
            common.WaitLoad(1000);
            common.ClickOnElement(regionAndMarketPageObject.DoneButtonRegion);
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
