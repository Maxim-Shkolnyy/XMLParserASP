using xmlParserASP.Entities;

namespace xmlParserASP.Models
{
    public class PriceQuantityViewModel
    {
        public double? Price { get; set; }
        public string? Quantity { get; set; }
        public string? SupplierId { get; set; }
        public string? Model { get; set; }
        public List<SupplierXmlSetting> SupplierXmlSettings { get; set; }
    }
}
