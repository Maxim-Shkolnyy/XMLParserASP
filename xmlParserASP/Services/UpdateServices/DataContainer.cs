using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;

namespace xmlParserASP.Services.UpdateServices;

public enum WhatToUpdate
{
    Price = 1, Quantity = 2, PriceAndQuantity = 3
}

public class DataContainer
{
    public MmSupplierXmlSetting? SupplierXmlSetting { get; set; } = null;
    public string? SuppName { get; set; } = "";
    public List<(string, string)>? StateMessages { get; set; }
    public string CurrentTableDbColumnToUpdate { get; set; } = "";
    public Dictionary<string, decimal> XmlModelPriceList { get; set; } = new();
    public Dictionary<string, string> XmlModelQuantityList { get; set; } = new();
    public List<MmSupplier>? SuppliersList { get; set; }
    public List<MmSupplierXmlSetting>? SuppSettingList { get; set; }
    public List<MmProductsManualSetPrice>? ProductsManualSetPrices { get; set; }
    public List<MmProductsManualSetQuanity>? ProductsManualSetQuanityList { get; set; }
    public List<MmProductsSetQuantityWhenMin>? ProductsSetQuantityWhenMinList { get; set; }
    public List<string>? SuppNameThatWasUpdatedList { get; set; }
    public List<int>? CurrentSuppProductIDList { get; set; }

    public List<(string, string, string, string, string)> DbCodeModelPriceList = new();
    public List<ProductNamesListModel> NamesOfProducts { get; set; } = new();
    public List<ProductMinInfoModel>? Products { get; set; }
    public int WhatToUpdate { get; set; } = 0;

}