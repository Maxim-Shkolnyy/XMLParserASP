using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XMLparser.TablesModels;

public class Language
{
    [Key]
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public string LanguageName { get; set; }
}
