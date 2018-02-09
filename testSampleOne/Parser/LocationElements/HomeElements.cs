using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testSampleOne.Parser.LocationElements
{
    class HomeElements : Elements
    {
        Node hamburgerMenuIcon = new Node();
        Node regionAndMarketsMenu = new Node();
        public HomeElements(string path) : base(path)
        {
        }

        public By GetHamburgerMenuIcon()
        {
            hamburgerMenuIcon = GetNodeByKey("HamburgerMenu");
            return ConvertToAttribute(hamburgerMenuIcon.Type,hamburgerMenuIcon.Value);
        }

        public By GetRegionAndMarketsMenu()
        {
            regionAndMarketsMenu = GetNodeByKey("RegionAndMarkets");
            return ConvertToAttribute(regionAndMarketsMenu.Type,regionAndMarketsMenu.Value);
        }


    }
}
