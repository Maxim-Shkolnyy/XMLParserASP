namespace xmlParserASP.Entities.TestGamma;

public partial class OcRelatedoption
{
    public int RelatedoptionsId { get; set; }

    public int? RelatedoptionsVariantProductId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public string? PricePrefix { get; set; }

    public decimal? Price { get; set; }

    public string? Model { get; set; }

    public string? Sku { get; set; }

    public string? Upc { get; set; }

    public string? Ean { get; set; }

    public string? Location { get; set; }

    public int? StockStatusId { get; set; }

    public bool? Defaultselect { get; set; }

    public int? Defaultselectpriority { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightPrefix { get; set; }

    public string Description { get; set; } = null!;
}
