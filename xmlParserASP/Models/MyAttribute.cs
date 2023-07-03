using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLparser.TablesModels;

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
