using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.GammaTables.MyTempToGamma;

public class Language
{
    [Key]
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public string LanguageName { get; set; }
}
