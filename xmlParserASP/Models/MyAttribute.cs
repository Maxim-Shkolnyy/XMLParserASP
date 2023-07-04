using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

public class MyAttribute
{
    [Key]
    [Required]
    public int MyAttrId {get; set;}
    
    [Required] 
    public string MyAttrName { get; set; }
    [Required]
    public int LanguageId { get; set; }
    //public ICollection<Supplier> Suppliers { get; set; }
    //public int SuppAttrIdEqualsOurAttr { get; set; }
    //public int SuppAttrNameEqualsOurAttr { get; set; }

}
