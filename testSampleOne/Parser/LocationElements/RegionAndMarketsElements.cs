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
        
        public RegionAndMarketsElements(string path) : base(path)
        {
        }

        public By GetNewBtn()
        {
            NewBtn = GetNodeByKey("NewButton");
            return ConvertToAttribute(NewBtn.Type, NewBtn.Value);
        }
    }
}
