namespace xmlParserASP.Models;

public class ProductMinInfoModel
{
    public int ProductId { get; set; }
    public string Sku { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int StockStatusId { get; set; }
    public string Name { get; set; }
    public int Category { get; set; }
}