using System.Xml;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

public static class UniqNodesInXML
{
    public static void Read()
    {
        string xmlFilePath = PathModel.Path; // work

        var nodeNames = new List<string>();
        var parameterLists = new List<List<string>>();

        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;
        settings.ProhibitDtd = false;
        //settings.MaxCharactersFromEntities = 1024;
        //settings.ValidationType = ValidationType.DTD;
        //settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

        using (XmlReader reader = XmlReader.Create(xmlFilePath, settings))
        {
            
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string elementName = reader.Name;

                    if (!nodeNames.Contains(elementName))
                    {
                        nodeNames.Add(elementName);
                    }

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            string attributeName = reader.Name;

                            if (!parameterLists.Exists(list => list.Contains(attributeName)))
                            {
                                parameterLists.Add(new List<string> { attributeName });
                            }
                        }

                        reader.MoveToElement();
                    }
                }
            }
        }
        PathModel.UniqueXMLNodes = nodeNames;

        //Console.WriteLine("Variables: \n");
        //foreach (var nodeName in nodeNames)
        //{
        //    Console.WriteLine(nodeName);
        //}
    }
}
