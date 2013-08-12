namespace Converter
{
    //downloaded through NuGet - Json.Net
    using Newtonsoft.Json;

    //From .Net Framework
    using System.Xml;

    public static class Parser
    {
        /// <summary>
        /// This is the json-to-xml converter
        /// </summary>
        /// <param name="json">Json formatted string</param>
        /// <returns>Xml document</returns>
        public static XmlDocument ParseJsonToXml(string json) 
        {
            var xmlDoc = JsonConvert.DeserializeXmlNode(json);
            return xmlDoc;
        }

        /// <summary>
        /// This is the xml-to-json converter
        /// </summary>
        /// <param name="xmlDoc">Xml document</param>
        /// <returns>Json-formatted string</returns>
        public static string XmlToJson(XmlDocument xmlDoc)
        {            
            var serializedXml = JsonConvert.SerializeXmlNode(xmlDoc.DocumentElement);
            return serializedXml;
        }
    }
}
