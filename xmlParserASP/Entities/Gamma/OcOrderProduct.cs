namespace xmlParserASP.Entities.Gamma;

public partial class OcOrderProduct
{
    public int OrderProductId { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Upc { get; set; } = null!;

    public string Ean { get; set; } = null!;

    public string Jan { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string Mpn { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal Weight { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string DiscountType { get; set; } = null!;

    public decimal Total { get; set; }

    public decimal Tax { get; set; }

    public int Reward { get; set; }
}
