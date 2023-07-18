using System.Xml;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

public class ReadAttrFromXmlTo3ColumnsUA
{
    public void ReadAttrTo3()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(PathModel.Path);

        XmlNodeList itemsList = doc.GetElementsByTagName(PathModel.XMLProductNode);

        XmlNodeList paramListForCount = doc.GetElementsByTagName("param");

        int paramsCount = paramListForCount.Count;

        string[,] array = new string[paramsCount + 1, 6];
        int paramIndex = 1;
        array[0, 0] = "product_id";
        array[0, 1] = "attribute_group";
        array[0, 2] = "attribute_id";
        array[0, 3] = "text(ru-ru)";
        array[0, 4] = "text(uk-ua)";


        int itemIndex = 0;
     
            foreach (XmlNode item in itemsList)
            {
            string modelID = item.SelectSingleNode(PathModel.XMLModelNode)?.InnerText; //feron
            //string modelID = item.Attributes["id"]?.Value; //Khoroz


                XmlNodeList paramList = item.SelectNodes(PathModel.XMLParamNode);

                foreach (XmlNode param in paramList)
                {
                    string paramGroup = "Характеристики";
                    string paramName = param.Attributes["name"]?.Value;
                    string paramValue = param.InnerText;
                    string paramId = "ru-attr";


                    array[paramIndex, 0] = modelID;
                    array[paramIndex, 1] = paramGroup;
                    array[paramIndex, 2] = paramName;
                    array[paramIndex, 3] = "";
                    array[paramIndex, 4] = paramValue;
                    array[paramIndex, 5] = modelID;

                    paramIndex++;
                }

                itemIndex++;
            }
            PathModel.SheetAtributes = array;       
    }
}