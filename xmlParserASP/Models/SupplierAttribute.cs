using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Models;

[PrimaryKey(nameof(SupAttrId), nameof(SupplierId), nameof(LanguageId))]
public class SupplierCategory
{
    [Required]
    public int SupAttrId { get; set; }
    public int SupplierId { get; set; }

    [Required]
    public string SupAttrName { get; set; }

    [Required]
    public int LanguageId { get; set; }

    //public ICollection<Supplier> Suppliers { get; set; }
    //public int SuppCatIdEqualsOurCat { get; set; }
    //public int SuppCatNameEqualsOurCat { get; set; }
    //[Required]
    //public ICollection<Language> Languages { get; set; }
}
