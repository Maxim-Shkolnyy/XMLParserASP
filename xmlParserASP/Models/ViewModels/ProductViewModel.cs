namespace xmlParserASP.Models.ViewModels;

public class ProductViewModel
{
    public int Id { get; set; }
    public string Sku { get; set; }
    public int SetInStockQty { get; set; }
    public DateTime? DateStart { get; set; }
    public DateTime? DateEnd { get; set; }
    public string Name { get; set; }
}