using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

public class Supplier
{
    [Key]
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public string SupplierName { get; set; }

}
