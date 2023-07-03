using System.Text;
using System.Xml.Linq;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

internal class ReadUniqueCategorys
{
    public void ReadXMLUniqueCategorys()
    {
        XDocument doc = XDocument.Load(PathListVarModel.Path); //work


        XElement? rootelement = doc.Element("params");

        var paramNames = doc.Descendants("param").Attributes("name").Select(attr => attr.Value).Distinct();
        //var paramNames = doc.Descendants("param").Attributes("name").Select(attr => attr.Value);


        int count = 0;
        // Обход полученных значений
        foreach (var paramName in paramNames)
        {
            count++;
            //Console.WriteLine($"{count} - {paramName}");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{paramName}");
            PathListVarModel.UniqXMLCategorys = paramNames.ToList();
        }
    }


    public void ReadXLUniqueCategorys()
    {

    }
}