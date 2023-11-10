using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities.TestGamma.OldMy;

//[PrimaryKey(nameof(MyCatId), nameof(LanguageId))]
public class MyCategory
{
    [Key]
    public int MyCatId { get; set; }
    public int MyParentCatId { get; set; }

    public string MyCatNameRU { get; set; }
    public string MyCatNameUA { get; set; }

    public ICollection<SupplierCategory> SupplierCategories { get; set; }
}
