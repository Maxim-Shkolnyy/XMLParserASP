using System.ComponentModel.DataAnnotations;
using xmlParserASP.Models;

namespace xmlParserASP.Entities;

public class Supplier
{
    [Key]
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public string SupplierName { get; set; }

    public ICollection<Product> Products { get; set; }
    public ICollection<SupplierXmlSetting>? SupplierXmlSettings { get; set; }

}
