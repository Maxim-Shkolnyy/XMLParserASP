using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

[PrimaryKey(nameof(MyCatId), nameof(LanguageId))]
public class MyCategory
{
    [Key]
    [Required]
    public int MyCatId {get; set;}
    public int MyParentCatId { get; set; }
    [Required]
    public string MyCatName { get; set;}
    [Required]
    public int LanguageId { get; set; }



    //[Required]
    //public ICollection<Supplier> Suppliers { get; set; }
    //public int SuppCatIdEqualsOurCat { get; set; }
    //public int SuppCatNameEqualsOurCat { get; set; }
    //[Required]
    //public ICollection<Language> Languages { get; set; }
}
