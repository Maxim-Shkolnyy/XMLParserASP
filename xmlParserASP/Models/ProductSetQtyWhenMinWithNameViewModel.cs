namespace xmlParserASP.Models
{
    public class ProductSetQtyWhenMinWithNameViewModel
    {
        public int Id { get; set; }
        public string Sku { get; set; } = null!;
        public int? MinQuantity { get; set; }
        public int SetQuantity { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
