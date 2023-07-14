using System.Text;
using System.Xml.Linq;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

internal class ReadUniqueCategorys
{
    public void ReadXMLUniqueCategorys()
    {
        XDocument doc = XDocument.Load(PathModel.Path); //work


        //XElement? rootelement = doc.Element("params");

        var paramNames = doc.Descendants(PathModel.XMLParamNode).Attributes(PathModel.XMLParamAttrNode).Select(attr => attr.Value).Distinct();
        //var paramNames = doc.Descendants("param").Attributes("name").Select(attr => attr.Value);

        PathModel.UniqXMLCategorys = paramNames.ToList();

        //int count = 0;
        
        //foreach (var paramName in paramNames)
        //{
        //    //count++;
        //    //Console.WriteLine($"{count} - {paramName}");
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.WriteLine($"{paramName}");
            
        //}
    }


    //public void ReadXLUniqueCategorys()
    //{

    //}
}