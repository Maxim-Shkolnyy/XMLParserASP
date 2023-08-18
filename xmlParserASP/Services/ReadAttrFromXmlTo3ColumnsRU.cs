using System.Xml;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services;

public class ReadAttrFromXmlTo3ColumnsRU
{
    private readonly MyDBContext _db;
    public ReadAttrFromXmlTo3ColumnsRU(MyDBContext db)
    {
            _db = db;
    }
    public void ReadAttrto3ru(int selectedSupplierXmlSetting)
    {
        var suppSetting = _db.SupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId==selectedSupplierXmlSetting);
        XmlDocument doc = new XmlDocument();
        doc.Load(PathModel.Path);

        XmlNodeList itemsList = doc.GetElementsByTagName(PathModel.ProductNode);

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
        if (PathModel.Language == Language.Ru)
        {
            foreach (XmlNode item in itemsList)
            {
                string modelID = item.SelectSingleNode(PathModel.ModelNode)?.InnerText; //feron
                //string modelID = item.Attributes["id"]?.Value; //Khoroz


                XmlNodeList paramList = item.SelectNodes(PathModel.ParamNode);

                foreach (XmlNode param in paramList)
                {
                    string paramGroup = "Характеристики";
                    string paramName = param.Attributes["name"]?.Value;
                    string paramValue = param.InnerText;
                    string paramId = "ru-attr";


                    array[paramIndex, 0] = modelID;
                    array[paramIndex, 1] = paramGroup;
                    array[paramIndex, 2] = paramName;
                    array[paramIndex, 3] = paramValue;
                    array[paramIndex, 4] = "";
                    array[paramIndex, 5] = modelID;

                    paramIndex++;
                }

                itemIndex++;
            }

            PathModel.SheetAtributes = array;
        }
        else
        {
            foreach (XmlNode item in itemsList)
            {
                string modelID = item.SelectSingleNode(PathModel.ModelNode)?.InnerText; //feron
                //string modelID = item.Attributes["id"]?.Value; //Khoroz


                XmlNodeList paramList = item.SelectNodes(PathModel.ParamNode);

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
}