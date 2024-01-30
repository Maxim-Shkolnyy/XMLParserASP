using xmlParserASP.Entities.Gamma;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services.UpdateServices;

public class DataContainer
{
    public MmSupplierXmlSetting? SupplierXmlSetting { get; set; }
    public string? SuppName { get; set; }
    public List<(string, string)>? StateMessages { get; set; }
    public string CurrentTableDbColumnToUpdate { get; set; } = "";
    public Dictionary<string, string> XmlModelPriceList { get; set; } = new();
    public List<MmSupplier>? SuppliersList { get; set; }
    public List<MmSupplierXmlSetting>? SuppSettingList { get; set; }
    public List<ProductsManualSetPrice>? ProductsManualSetPrices { get; set; }
    public List<ProductsManualSetQuanity>? ProductsManualSetQuanityList { get; set; }
    public List<ProductsSetQuantityWhenMin>? ProductsSetQuantityWhenMinList { get; set; }
    public List<string>? SuppNameThatWasUpdatedList { get; set; }
}