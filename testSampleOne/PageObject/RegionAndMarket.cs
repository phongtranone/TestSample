using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    class RegionAndMarket : Elements
    {
        // private By RegionAndMarketMenu = By.XPath("//a[text()=' Region and Market']");
        //private By NewBtn = By.XPath("//button[text()='New ']");
        // private By RegionItem = By.XPath("//ul/li/a[text()='Region']");
        //private By RegionName = By.XPath("//div/input[@placeholder='Region name']");
        //private By RegionDescription = By.XPath("//div[descendant::span[@id='vali-description']]/textarea[@name='description']");
        //private By DoneBtnRegion = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Region name']]//div[@class='modal-footer']//button");

        //private By MarketItem = By.XPath("//ul/li/a[text()='Market']");
        //private By MarketName = By.XPath("//div/input[@placeholder='Market name']");
        //private By MarketDescription = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Market name']]//input[@placeholder='Description']");
        //private By DoneBtnMarket = By.XPath("//div[@class='modal-content' and descendant::input[@placeholder='Market name']]//button[text()='Done']");

        string xmlFilePath = "LocationElements\\RegionAndMarkets.xml";
        RegionAndMarketsElements regionAndMarketsElements;
        public By NewBtn { get; set; }

        public By RegionItem { get; set; }
        public By RegionName
        {
            get
            {
                var nodeRegionName = GetNodeByKey("RegionName");
                return ConvertToAttribute(nodeRegionName.Type, nodeRegionName.Value);
            }
        }
    
        public By RegionDescription { get; set; }
        public By DoneButtonRegion { get; set; }

        public By MarketItem { get; set; }
        public By MarketName { get; set; }
        public By MarketDescription { get; set; }
        public By DoneButtonMarket { get; set; }

        public RegionAndMarket():this("LocationElements\\RegionAndMarkets.xml")
        {
            //regionAndMarketsElements = new RegionAndMarketsElements(xmlFilePath);

            //NewBtn = regionAndMarketsElements.GetNewBtn();

            //RegionItem = regionAndMarketsElements.GetRegionItem();
            //RegionName = regionAndMarketsElements.GetRegionName();
            //RegionDescription = regionAndMarketsElements.GetRegionDescription();
            //DoneButtonRegion = regionAndMarketsElements.GetDoneButtonRegion();

            //MarketItem = regionAndMarketsElements.GetMarketItem();
            //MarketName = regionAndMarketsElements.GetMarketName();
            //MarketDescription = regionAndMarketsElements.GetMarketDescription();
            //DoneButtonMarket = regionAndMarketsElements.GetDoneButtonMarket();
        }

        public RegionAndMarket(string path) : base(path)
        {
           
            
        }

        //public By GetRegionAndMarketMenu()
        //{
        //    return RegionAndMarketMenu;
        //}

        //public By GetNewBtn()
        //{
        //    return NewBtn;
        //}

        //public By GetRegionItem()
        //{
        //    return RegionItem; 
        //}

        //public By GetRegionName()
        //{
        //    return RegionName;
        //}

        //public By GetRegionDescription()
        //{
        //    return RegionDescription;
        //}

        //public By GetDoneBtnRegion()
        //{
        //    return DoneBtnRegion;
        //}

        //public By GetMarketItem()
        //{
        //    return MarketItem;
        //}

        //public By GetMarketName()
        //{
        //    return MarketName;
        //}

        //public By GetMarketDescription()
        //{
        //    return MarketDescription;
        //}

        //public By GetDoneBtnMarket()
        //{
        //    return DoneBtnMarket;
        //}

    }
}
