using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

[PrimaryKey(nameof(MyCatId), nameof(LanguageId))]
public class MyCategory
{    
    [Required]
    public int MyCatId {get; set;}
    public int MyParentCatId { get; set; }
    [Required]
    public string MyCatName { get; set;}
    [Required]
    public int LanguageId { get; set; }
}
