using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(MyAttrId), nameof(LanguageId))]
public class MyAttribute
{
    [Key]
    
    public int MyAttrId { get; set; }

    [Required]
    public string MyAttrNameRU { get; set; }
    [Required]
    public string MyAttrNameUA { get; set; }

    public string? MyAttrGroup { get; set; }
    public ICollection <SupplierAttribute> SupplierAttributes {get; set;} 

}
