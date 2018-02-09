using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    class RegionAndMarket
    {
        private By RegionAndMarketMenu = By.XPath("//a[text()=' Region and Market']");
        //private By NewBtn = By.XPath("//button[text()='New ']");
        private By RegionItem = By.XPath("//ul/li/a[text()='Region']");
        private By RegionName = By.XPath("//div/input[@placeholder='Region name']");
        private By RegionDescription = By.XPath("//div[span[@id='vali-description']]/textarea");
        private By DoneBtnRegion = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Region name']]//div[@class='modal-footer']//button");

        private By MarketItem = By.XPath("//ul/li/a[text()='Market']");
        private By MarketName = By.XPath("//div/input[@placeholder='Market name']");
        private By MarketDescription = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Market name']]//input[@placeholder='Description']");
        private By DoneBtnMarket = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Market name']]//button[text()='Done']");

        string xmlFilePath = "LocationElements\\RegionAndMarkets.xml";
        RegionAndMarketsElements regionAndMarketsElements;
        public By NewBtn { get; set; }

        public RegionAndMarket()
        {
            regionAndMarketsElements = new RegionAndMarketsElements(xmlFilePath);
            NewBtn = regionAndMarketsElements.GetNewBtn();
        }

        public By GetRegionAndMarketMenu()
        {
            return RegionAndMarketMenu;
        }

        public By GetNewBtn()
        {
            return NewBtn;
        }

        public By GetRegionItem()
        {
            return RegionItem; 
        }

        public By GetRegionName()
        {
            return RegionName;
        }

        public By GetRegionDescription()
        {
            return RegionDescription;
        }

        public By GetDoneBtnRegion()
        {
            return DoneBtnRegion;
        }

        public By GetMarketItem()
        {
            return MarketItem;
        }

        public By GetMarketName()
        {
            return MarketName;
        }

        public By GetMarketDescription()
        {
            return MarketDescription;
        }

        public By GetDoneBtnMarket()
        {
            return DoneBtnMarket;
        }

    }
}
