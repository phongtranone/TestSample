using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.PageObject;

namespace testSampleOne.TestCases
{
    public class CreatNewRegion
    {
        Common common = new Common();
        LoginPage loginPage = new LoginPage();
        HomePage homePage = new HomePage();
        RegionAndMarket RegionAndMarketPage = new RegionAndMarket();

        public CreatNewRegion()
        {
            
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
            common.ClickOnElement(RegionAndMarketPage.NewBtn);
            common.ClickOnElement(RegionAndMarketPage.GetRegionItem());
            common.WaitLoad(2000);
            common.InputData(RegionAndMarketPage.GetRegionName(),"Region name " + common.GetCurrentDate);
            common.WaitLoad(2000);
            common.InputData(RegionAndMarketPage.GetRegionDescription(), "Region description " + common.GetCurrentDate);
            common.ClickOnElement(RegionAndMarketPage.GetDoneBtnRegion());
            common.WaitLoad(5000);
            common.CloseBrowser();
        }
    }
}
