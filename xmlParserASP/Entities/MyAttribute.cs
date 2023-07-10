using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(MyAttrId), nameof(LanguageId))]
public class MyAttribute
{
    [Key]
    [Required]
    public int MyAttrId { get; set; }

    [Required]
    public string MyAttrNameRU { get; set; }
    [Required]
    public string MyAttrNameUA { get; set; }

    public int MyAttrGroup { get; set; } = 0;
    public ICollection <SupplierAttribute> SupplierAttributes {get; set;} 

}
