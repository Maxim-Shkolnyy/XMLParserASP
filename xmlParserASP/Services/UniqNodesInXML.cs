using System.Configuration;
using System.Xml;
using System.Xml.Schema;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services;

public class UniqNodesInXML
{
    private readonly MyDBContext _db;
    public UniqNodesInXML(MyDBContext db)
    {
        _db = db;
    }
    public void Read(int selectedSupplierXmlSetting)
    {
        var suppSetting = _db.SupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId==selectedSupplierXmlSetting);

        string xmlFilePath = suppSetting.Path; // work

        var nodeNames = new List<string>();
        var parameterLists = new List<List<string>>();

        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Ignore; // Игнорировать DTD
        settings.ValidationType = ValidationType.None; // Отключить валидацию
        settings.IgnoreProcessingInstructions = true; // Игнорировать инструкции обработки

        //XmlReaderSettings settings = new XmlReaderSettings();
        //settings.DtdProcessing = DtdProcessing.Parse;
        //settings.ProhibitDtd = false;
        //settings.MaxCharactersFromEntities = 1024;
        //settings.ValidationType = ValidationType.DTD;
        //settings.ValidationEventHandler += new ValidationEventHandler(ValidatorCallback);

        try
        {
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
        catch (Exception ex)
        {
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

            PathModel.UniqueXMLNodes = nodeNames;
        }
    }
}
