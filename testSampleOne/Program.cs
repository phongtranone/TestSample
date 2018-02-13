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
    class Program
    {
        static void Main(string[] args)
        {
            CreatNewRegion TC_CreateNewRegion = new CreatNewRegion();
            TC_CreateNewRegion.RunTest();
            Console.ReadLine();
        }


    }
}
