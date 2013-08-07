using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new System.Xml.XmlDocument();
            doc.Load("../../App.config");

            var parsed = Parser.XmlToJson(doc);
            Console.WriteLine(parsed.Replace("{","\n{"));

            var newDoc = Parser.ParseJsonToXml(parsed);            
            newDoc.Save("../../App_Copy.config");
        }
    }
}
