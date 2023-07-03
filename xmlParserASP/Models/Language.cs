using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

public class Language
{
    [Key]
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public string LanguageName { get; set; }
}
