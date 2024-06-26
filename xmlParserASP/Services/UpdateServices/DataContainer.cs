﻿using xmlParserASP.Entities.Gamma;
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
    public Dictionary<string, int> XmlModelQuantityList { get; set; } = new();
    public List<MmSupplier>? SuppliersList { get; set; }
    public List<MmSupplierXmlSetting>? SuppSettingList { get; set; }
    public List<MmProductsSetQuantityWhenMin>? ProductsSetQuantityWhenMinList { get; set; }
    public List<string>? SuppNameThatWasUpdatedList { get; set; }
    public List<int>? CurrentSuppProductIDList { get; set; }
    public int FoundItemsInXmlForCurrentSupp { get; set; }
    public int NotFoundItemsInXmlForCurrentSupp { get; set; }
    public int FoundProductsInDbForCurrentSupp { get; set; }
    public int ProductsWasChanged { get; set; }
    public int ProductsWasNotChanged { get; set; }
    public int ProductQtySetManually { get; set; }

    public List<(string, string, decimal, int, string)> DbCodeModelPriceList = new();
    public List<ProductNamesListModel> NamesOfProducts { get; set; } = new();
    public List<ProductMinInfoModel>? Products { get; set; }
    public int WhatToUpdate { get; set; } = 0;
    public List<string> SkusToUpdate { get; set; } = new();
    public float? ExchangeRate { get; set; }
    public float? Markup { get; set; }
}