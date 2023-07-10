using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(SupplierCatId), nameof(SupplierId), nameof(LanguageId))]
public class SupplierCategory
{
    [Key]
    [Required]
    public int SupplierCatId { get; set; }
    [Required]
    public int SupplierId { get; set; }
    public int ParentSupCatId { get; set; }
    [Required]
    public string CatNameRU { get; set; }
    public string CatNameUA { get; set; }
    public ICollection<MyCategory> MyCategories { get; set; }

    //public int SuppCatIdEqualsOurCat { get; set; }
    //public int SuppCatNameEqualsOurCat { get; set; }
    //[Required]
    //public ICollection<Language> Languages { get; set; }
}
