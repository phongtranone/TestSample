using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testSampleOne.Parser.LocationElements
{
   public class LocationElements
    {
        //Path of XML file
        protected string xmlFilePath;
        //define root
        private XDocument xmlFile;
        //List<XElement> elements;

        IEnumerable<XElement> root;
        public LocationElements()
        {
            xmlFile = XDocument.Load(xmlFilePath);
            root = xmlFile.Elements();

            foreach (var element in root)
            {
                //elements.Add(element);
            }
        }
        //define NODE array
        
        //define method get element
    }
}
