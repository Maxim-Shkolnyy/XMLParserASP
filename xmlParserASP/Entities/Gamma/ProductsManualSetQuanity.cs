namespace xmlParserASP.Entities.Gamma;

public partial class ProductsManualSetQuanity
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public int SetInStockQty { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
