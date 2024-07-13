using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmSupplierXmlSetting
{
    [Key]
    public int SupplierXmlSettingId { get; set; }

    public string SettingName { get; set; } = null!;

    public int SupplierId { get; set; }

    public string? Path { get; set; }

    public string? MainProductNode { get; set; }

    public string? ProductNode { get; set; }

    public string? ParamAttribute { get; set; }

    public string? ModelNode { get; set; }

    public string? ModelXlColumn { get; set; }

    public string? PriceNode { get; set; }

    public string? DescriptionNode { get; set; }

    public string? NameNode { get; set; }

    public string? CurrencyNode { get; set; }

    public string? PictureNode { get; set; }

    public string? PricePictureXlColumn { get; set; }

    public string? QuantityXlColumn { get; set; }

    public string? PhotoFolder { get; set; }

    public string? QuantityNode { get; set; }

    public string? QuantityDbStock1 { get; set; }

    public string? QuantityDbStock2 { get; set; }

    public string? QuantityDbStock3 { get; set; }

    public string? QuantityDbStock4 { get; set; }

    public string? QuantityDbStock5 { get; set; }

    public string? QuantityDbStock6 { get; set; }

    public string? QuantityDbStock7 { get; set; }

    public string? QuantityDbStock8 { get; set; }

    public string? QuantityDbStock9 { get; set; }

    public string? QuantityLongTermNode { get; set; }

    public string? SupplierNode { get; set; }

    public string? ParamNode { get; set; }

    public string? ParamAttrNode { get; set; }

    public string? QtyInBoxColumnNumber { get; set; }
}
