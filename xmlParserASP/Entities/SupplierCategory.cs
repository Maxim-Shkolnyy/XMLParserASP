using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities;

[PrimaryKey(nameof(SupplierCatId), nameof(SupplierId), nameof(LanguageId))]
public class SupplierCategory
{
    [Required]
    public int SupplierCatId { get; set; }

    [Required]
    public int SupplierId { get; set; }

    public int ParentSupCatId { get; set; }
    [Required]
    public string Cat_Name { get; set; }
    [Required]
    public int LanguageId { get; set; }

    //public ICollection<Supplier> Suppliers { get; set; }
    //public int SuppCatIdEqualsOurCat { get; set; }
    //public int SuppCatNameEqualsOurCat { get; set; }
    //[Required]
    //public ICollection<Language> Languages { get; set; }
}
