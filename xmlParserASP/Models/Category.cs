using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

public class Category
{
    [Key]
    [Required]
    public int CatId {get; set;}
    public int ParentCatId { get; set; }
    [Required]
    public string Cat_Name { get; set;}
    [Required]
    public ICollection<Supplier> Suppliers { get; set; }
    public int SuppCatIdEqualsOurCat { get; set; }
    public int SuppCatNameEqualsOurCat { get; set; }
    [Required]
    public ICollection<Language> Languages { get; set; }
}
