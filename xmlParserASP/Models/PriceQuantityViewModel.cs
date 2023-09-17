using System.ComponentModel.DataAnnotations;
using xmlParserASP.Entities;

namespace xmlParserASP.Models
{
    public class PriceQuantityViewModel
    {
        public float? Price { get; set; }
        public int? Quantity { get; set; }
        public int? SupplierId { get; set; }
        public string? Model { get; set; }
        public List<SupplierXmlSetting>? SupplierXmlSettings { get; set; }
        [Required(ErrorMessage = "Select a supplier")]
        public int SupplierXmlSettingId { get; set; }
        public bool IsChecked { get; set; }
    } 
}
