using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

[PrimaryKey(nameof(MyAttrId), nameof(LanguageId))]
public class MyAttribute
{
    [Required]
    public int MyAttrId { get; set; }

    [Required]
    public string MyAttrName { get; set; }
    [Required]
    public int LanguageId { get; set; }
}
