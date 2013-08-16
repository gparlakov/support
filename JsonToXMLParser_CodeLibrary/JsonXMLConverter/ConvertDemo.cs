using System;

namespace Converter
{
    class ConvertDemo
    {
        static void Main(string[] args)
        {
            //Takes an xml - this is the app.config file from the assembly
            var xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load("../../App.config");

            //Converts xml to json
            var json = Parser.XmlToJson(xmlDoc);

            //shows the json on console
            Console.WriteLine(json);

            //Converts json back to xml 
            var newXmlDoc = Parser.ParseJsonToXml(json);            

            //saves as new doc app_copy.xml
            newXmlDoc.Save("../../App_Copy.xml");
        }
    }
}
