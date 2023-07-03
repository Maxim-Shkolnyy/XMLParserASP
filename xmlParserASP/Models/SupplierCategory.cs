using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Models;

[PrimaryKey(nameof(CatId), nameof(SupplierId), nameof(LanguageId))]
public class SupplierCategory
{
    public int SupplierId { get; set; }

    public int LanguageId { get; set; }

    [Required]
    public int CatId { get; set; }

    public int ParentCatId { get; set; }
    [Required]
    public string Cat_Name { get; set; }

    //public ICollection<Supplier> Suppliers { get; set; }
    //public int SuppCatIdEqualsOurCat { get; set; }
    //public int SuppCatNameEqualsOurCat { get; set; }
    //[Required]
    //public ICollection<Language> Languages { get; set; }
}
