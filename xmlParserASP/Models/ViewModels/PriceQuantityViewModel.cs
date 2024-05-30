using System.ComponentModel.DataAnnotations;
using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Models.ViewModels;

public class PriceQuantityViewModel
{
    public float? Price { get; set; }
    public int? Quantity { get; set; }
    public int? SupplierId { get; set; }
    public string? Model { get; set; }
    public List<MmSupplierXmlSetting>? SupplierXmlSettings { get; set; }
    [Required(ErrorMessage = "Select a supplier")]
    public int SupplierXmlSettingId { get; set; }
    public List<int>? PriceList { get; set; }
    public List<int>? QuantityList { get; set; }
    public bool IsChecked { get; set; }
    public string? ErrorMessage { get; set; }
}
