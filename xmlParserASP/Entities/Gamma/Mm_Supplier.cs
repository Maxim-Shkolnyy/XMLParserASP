using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using xmlParserASP.Entities.Gamma;
using xmlParserASP.Models;

namespace xmlParserASP.Entities;

public class Mm_Supplier
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Supplier name must be between 3 and 50 characters.")]
    public string SupplierName { get; set; }
    public ICollection<OcProduct>? Products { get; set; }
    public ICollection<Mm_SupplierXmlSetting>? SupplierXmlSetting { get; set; }

}
