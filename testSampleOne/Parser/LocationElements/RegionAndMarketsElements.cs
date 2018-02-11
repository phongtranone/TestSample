using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testSampleOne.Parser.LocationElements
{
    class RegionAndMarketsElements : Elements
    {
        Node NewBtn = new Node();

        Node RegionItem = new Node();
        Node RegionName = new Node();
        Node RegionDescription = new Node();
        Node DoneButtonRegion = new Node();

        Node MarketItem = new Node();
        Node MarketName = new Node();
        Node MarketDescription = new Node();
        Node DoneButtonMarket = new Node();

        public RegionAndMarketsElements(string path) : base(path)
        {
        }

        public By GetNewBtn()
        {
            NewBtn = GetNodeByKey("NewButton");
            return ConvertToAttribute(NewBtn.Type, NewBtn.Value);
        }

        public By GetRegionItem()
        {
            RegionItem = GetNodeByKey("RegionItem");
            return ConvertToAttribute(RegionItem.Type, RegionItem.Value);
        }

        public By GetRegionName()
        {
            RegionName = GetNodeByKey("RegionName");
            return ConvertToAttribute(RegionName.Type, RegionName.Value);
        }

        public By GetRegionDescription()
        {
            RegionDescription = GetNodeByKey("RegionDescription");
            return ConvertToAttribute(RegionDescription.Type, RegionDescription.Value);
        }

        public By GetDoneButtonRegion()
        {
            DoneButtonRegion = GetNodeByKey("DoneButtonRegion");
            return ConvertToAttribute(DoneButtonRegion.Type, DoneButtonRegion.Value);
        }

        public By GetMarketItem()
        {
            MarketItem = GetNodeByKey("MarketItem");
            return ConvertToAttribute(MarketItem.Type, MarketItem.Value);
        }

        public By GetMarketName()
        {
            MarketName = GetNodeByKey("MarketName");
            return ConvertToAttribute(MarketName.Type, MarketName.Value);
        }

        public By GetMarketDescription()
        {
            MarketDescription = GetNodeByKey("MarketDescription");
            return ConvertToAttribute(MarketDescription.Type, MarketDescription.Value);
        }

        public By GetDoneButtonMarket()
        {
            DoneButtonMarket = GetNodeByKey("DoneButtonMarket");
            return ConvertToAttribute(DoneButtonMarket.Type, DoneButtonMarket.Value);
        }
    }
}
