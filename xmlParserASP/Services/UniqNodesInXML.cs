using System.Xml;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

public static class UniqNodesInXML
{
    public static void Read()
    {
        string xmlFilePath = PathListVarModel.Path; // work

        var nodeNames = new List<string>();
        var parameterLists = new List<List<string>>();

        using (XmlReader reader = XmlReader.Create(xmlFilePath))
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

        Console.WriteLine("Variables: \n");
        PathListVarModel.UniqXMLAttr = nodeNames;

        foreach (var nodeName in nodeNames)
        {
            Console.WriteLine(nodeName);
        }
    }
}
