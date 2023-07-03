using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

public class MyAttribute
{
    [Key]
    [Required]
    public int AttrId {get; set;}
    [Required]
    public int ParentAttrId { get; set; }

    [Required] 
    public string Attr_Name { get; set; }
    public ICollection<Supplier> Suppliers { get; set; }
    public int SuppAttrIdEqualsOurAttr { get; set; }
    public int SuppAttrNameEqualsOurAttr { get; set; }
    [Required]
    public ICollection<Language> Languages { get; set; }
}
