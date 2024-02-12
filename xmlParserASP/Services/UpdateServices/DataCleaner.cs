using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;


namespace xmlParserASP.Services.UpdateServices;

public class DataCleaner
{

    private DataContainer _dc;

    public DataCleaner(DataContainerSingleton dcS)
    {
        _dc = dcS.Instance;
    }

    public void CleanUp()
    {
        if (_dc.StateMessages != null)
            _dc.StateMessages.Clear();

        if (_dc.XmlModelPriceList.Count > 0)
            _dc.XmlModelPriceList.Clear();

        if (_dc.XmlModelQuantityList.Count > 0)
            _dc.XmlModelQuantityList.Clear();

        if (_dc.ProductsManualSetPrices != null)
            _dc.ProductsManualSetPrices.Clear();

        if (_dc.ProductsManualSetQuanityList != null)
            _dc.ProductsManualSetQuanityList.Clear();

        if (_dc.ProductsSetQuantityWhenMinList != null)
            _dc.ProductsSetQuantityWhenMinList.Clear();

        if (_dc.CurrentSuppProductIDList != null)
            _dc.CurrentSuppProductIDList.Clear();

        if (_dc.DbCodeModelPriceList.Count > 0)
            _dc.DbCodeModelPriceList.Clear();

        if (_dc.NamesOfProducts.Count > 0)
            _dc.NamesOfProducts.Clear();

        if (_dc.Products != null)
            _dc.Products.Clear();

        if (_dc.SkusToUpdate.Count > 0)
            _dc.SkusToUpdate.Clear();
    }
}

