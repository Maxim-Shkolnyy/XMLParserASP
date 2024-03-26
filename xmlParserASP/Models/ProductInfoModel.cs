using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Models
{
    public class ProductInfoModel
    {

        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int StockStatusId { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public List<NgProductDiscount> productDiscounts { get; set; }
        public List<NgProductSpecial> ngProductSpecials { get; set; }

    }
}
