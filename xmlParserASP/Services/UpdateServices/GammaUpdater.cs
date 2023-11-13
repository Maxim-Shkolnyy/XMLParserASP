namespace xmlParserASP.Services.UpdateServices;

public class GammaUpdater : ISupplierUpdater
{
    public Task<List<(string, string)>> Update(string tableColumnToUpdate)
    {
        throw new NotImplementedException();
    }

    private void GetGammaQuantityXmlValues()
    {
        //XmlDocument xmlDoc = new();

        //string priceOrQuantityNode = "";
        //string model = "";
        //xmlModelPriceList.Clear();

        //xmlDoc.Load(suppSettings.Path);

        //XmlNodeList itemsList = xmlDoc.GetElementsByTagName(suppSettings.ProductNode);


        //foreach (XmlNode item in itemsList)
        //{
        //    if (suppSettings.paramAttribute == null)
        //    {
        //        if (item.SelectSingleNode(suppSettings.ModelNode) == null)
        //        {
        //            continue;
        //        }
        //        model = item.SelectSingleNode(suppSettings.ModelNode)?.InnerText;
        //    }
        //    else
        //    {
        //        if (item.Attributes["id"] != null)
        //        {
        //            model = item.Attributes["id"]?.Value;
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }

        //    int stock1 = 0;
        //    int stock2 = 0;
        //    int stock3 = 0;

        //    if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock1)?.InnerText, out stock1))
        //    {
        //        stock1 = 0;
        //    }

        //    if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock2)?.InnerText, out stock2))
        //    {
        //        stock2 = 0;
        //    }

        //    if (!int.TryParse(item.SelectSingleNode(suppSettings.QuantityDBStock3)?.InnerText, out stock3))
        //    {
        //        stock3 = 0;
        //    }

        //    int aggregatedQuantity = stock1 + stock2 + stock3;

        //    priceOrQuantityNode = aggregatedQuantity.ToString();

        //    if (!xmlModelPriceList.ContainsKey(model))
        //    {
        //        xmlModelPriceList.Add(model, priceOrQuantityNode);
        //    }
    }
}