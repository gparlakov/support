using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace ConsoleApplication1
{
    public static class Parser
    {
        public static XmlDocument ParseJsonToXml(string json) 
        {
            var xmlDoc = JsonConvert.DeserializeXmlNode(json);
            return xmlDoc;
        }

        public static string XmlToJson(XmlDocument xmlDoc)
        {            
            var serializedXml = JsonConvert.SerializeXmlNode(xmlDoc.DocumentElement);
            return serializedXml;
        }
    }
}
