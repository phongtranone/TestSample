﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;

namespace testSampleOne.Parser.LocationElements
{
    class Elements
    {
        public List<Node> Nodes { get; set; }

        public Elements(string path)
        {
            XDocument CommonsData = XDocument.Load(path);
            Nodes = new List<Node>();
            foreach (var element in CommonsData.Root.Elements())
            {
                Nodes.Add(new Node
                {
                    Key = element.Name.LocalName,
                    Type = element.Attribute("type").Value,
                    Value = element.Value
                });

            }
        }

        public By FindElementByKey(string keyName)
        {
            var node = GetNodeByKey(keyName);
            return ConvertToAttribute(node.Type, node.Value);
        }

        public Node GetNodeByKey(string key)
        {
            return Nodes.FirstOrDefault(node => node.Key.Equals(key));
        }

        public By ConvertToAttribute(string type, string value)
        {
            switch (type)
            {
                case "id":
                    return By.Id(value);
                case "xpath":
                    return By.XPath(value);
                default:
                    return null;
            }
        }
    }

    class Node
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
