using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    public class HomePage
    {
        string xmlFilePath = "LocationElements\\HomePage.xml";
        HomeElements homeElements;
        public By HamburgerMenuIcon { get; set; }
        public By RegionAndMarketsMenu { get; set; }

        public HomePage()
        {
            homeElements = new HomeElements(xmlFilePath);
            HamburgerMenuIcon = homeElements.GetHamburgerMenuIcon();
            RegionAndMarketsMenu = homeElements.GetRegionAndMarketsMenu();
        }
    }
}
