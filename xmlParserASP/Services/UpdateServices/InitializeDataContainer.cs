using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Services.UpdateServices;

public class DataContainerSingleton
{
    private static readonly Lazy<DataContainer> _lazyInstance = new Lazy<DataContainer>(InitializeDataContainer);

    public DataContainer Instance => _lazyInstance.Value;

    private static DataContainer InitializeDataContainer()
    {
        DataContainer dc = new DataContainer();

        dc.CurrentTableDbColumnToUpdate = "";
        dc.SupplierXmlSetting = new MmSupplierXmlSetting();
        dc.SuppName = "";
        dc.StateMessages = new List<(string, string)>();
        dc.ProductsManualSetPrices = new List<ProductsManualSetPrice>();
        dc.ProductsManualSetQuanityList = new List<ProductsManualSetQuanity>();
        dc.ProductsSetQuantityWhenMinList = new List<ProductsSetQuantityWhenMin>();
        dc.SuppNameThatWasUpdatedList = new List<string>();
        dc.SuppliersList = new List<MmSupplier>();
        dc.SuppSettingList = new List<MmSupplierXmlSetting>();
        dc.XmlModelPriceList = new Dictionary<string, string>();

        return dc;
    }
}
