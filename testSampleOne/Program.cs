using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testSampleOne.Parser.LocationElements;
using testSampleOne.TestCases;

namespace testSampleOne
{
    [XmlRoot("Login")]
    public class Login
    {
        private Username username;

        [XmlElement("Username")]
        public Username Username
        {
            get { return username; }
            set { username = value; }
        }

    }

    public class Username
    {
        private string nameValue;
        private string typeElement;

        [XmlAttribute("name")]
        public string name
        {
            get { return typeElement; }
            set { typeElement = value; }
        }

        [XmlText()]
        public string Value
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

    }

    public class LocationElements
    {
        //Path of XML file
        protected string xmlFilePath;
        //define root
        //private XDocument xmlFile;
       // List<XElement> elements;

        IEnumerable<XElement> root;
        public LocationElements(string path)
        {
            this.xmlFilePath = path;
            XDocument xmlFile = XDocument.Load(xmlFilePath);
            var root = xmlFile.Root;


            Console.WriteLine(root.Element("Username").Value);
        }
        //define NODE array

        //define method get element
    }

    public class Animal
    {
        private string name="test";

        public string ShowName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Elements element = new Elements("LocationElements\\Login.xml");
            //Node node = new Node();
            //node = element.GetNodeByKey("LoginButton");
            //Console.WriteLine(node.Value);


            //Animal animal = new Animal();
            //Console.WriteLine(animal.ShowName());


            // string xmlFilePath = "LocationElements\\Login.xml";
            // LocationElements element = new LocationElements(xmlFilePath);
            // Console.WriteLine(element);
            // Console.ReadLine();

            //var xml1 = XDocument.Load("InputData\\CommonsData.xml");
            //XmlSerializer serializer1 = new XmlSerializer(typeof(Login));
            //Login ei1 = (Login)serializer1.Deserialize(XmlReader.Create("LocationElements\\Login.xml"));
            //Console.WriteLine(ei1.Username.Value);


            CreatNewRegion TC_CreateNewRegion = new CreatNewRegion();
            TC_CreateNewRegion.RunTest();
            Console.ReadLine();
            // CreatNewMarket TC_CreateNewMarket = new CreatNewMarket();
            // // TC_CreateNewMarket.RunTest();

            // CreatInsurancePolicy TC_CreateInsurancePolicy = new CreatInsurancePolicy();
            //// TC_CreateInsurancePolicy.RunTest();

            // CreateRequestType TC_CreateRequestType = new CreateRequestType();
            // //TC_CreateRequestType.RunTest();

            // XmlReader Reader = XmlReader.Create("\\DataInput\\CommonsData.xml");





        }
    }
}
