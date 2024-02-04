using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;

namespace xmlParserASP.Services.UpdateServices;

public class DataContainer
{
    public MmSupplierXmlSetting? SupplierXmlSetting { get; set; } = null;
    public string? SuppName { get; set; } = "";
    public List<(string, string)>? StateMessages { get; set; }
    public string CurrentTableDbColumnToUpdate { get; set; } = "";
    public Dictionary<string, string> XmlModelPriceList { get; set; } = new();
    public List<MmSupplier>? SuppliersList { get; set; }
    public List<MmSupplierXmlSetting>? SuppSettingList { get; set; }
    public List<ProductsManualSetPrice>? ProductsManualSetPrices { get; set; }
    public List<ProductsManualSetQuanity>? ProductsManualSetQuanityList { get; set; }
    public List<ProductsSetQuantityWhenMin>? ProductsSetQuantityWhenMinList { get; set; }
    public List<string>? SuppNameThatWasUpdatedList { get; set; }
    public List<int>? CurrentSuppProductIDList { get; set; }

    public List<(string, string, string, string, string)> DbCodeModelPriceList = new();
    public List<ProductNamesListModel> NamesOfProducts { get; set; } = new();
    public List<ProductMinInfoModel>? Products { get; set; }
}