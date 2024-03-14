using System.Xml;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD;

public class ReadAttrFromXmlTo3ColumnsRU
{
    private readonly GammaContext _db;
    public ReadAttrFromXmlTo3ColumnsRU(GammaContext db)
    {
        _db = db;
    }
    public void ReadAttrto3ru(int selectedSupplierXmlSetting)
    {
        var suppSetting = _db.MmSupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId == selectedSupplierXmlSetting);
        XmlDocument doc = new XmlDocument();
        doc.Load(suppSetting.Path);

        XmlNodeList itemsList = doc.GetElementsByTagName(suppSetting.ProductNode);

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
                string modelID = item.SelectSingleNode(suppSetting.ModelNode)?.InnerText; //feron
                //string modelID = item.Attributes["id"]?.Value; //Khoroz


                XmlNodeList paramList = item.SelectNodes(suppSetting.ParamNode);

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
                string? modelID;

                if (suppSetting.ParamAttribute == null)
                {
                    modelID = item.SelectSingleNode(suppSetting.ModelNode)?.InnerText;
                }
                else
                {
                    modelID = item.Attributes["id"]?.Value;
                }

                XmlNodeList paramList = item.SelectNodes(suppSetting.ParamNode);

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