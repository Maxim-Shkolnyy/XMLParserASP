using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(MyCatId), nameof(LanguageId))]
public class MyCategory
{
    [Key]
    [Required]
    public int MyCatId { get; set; }
    public int MyParentCatId { get; set; }
   
    public string MyCatNameRU { get; set; }
    public string MyCatNameUA { get; set; }

    public ICollection<SupplierCategory> SupplierCategories { get; set; }
}
