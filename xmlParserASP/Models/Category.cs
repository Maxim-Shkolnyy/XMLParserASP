using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLparser.TablesModels;

public class Category
{
    [Key]
    [Required]
    public int CatId {get; set;}
    public int ParentCatId { get; set; }
    [Required]
    public string Cat_Name { get; set;}
    [Required]
    public ICollection<Supplier> Suppliers { get; set; }
    public int SuppCatIdEqualsOurCat { get; set; }
    public int SuppCatNameEqualsOurCat { get; set; }
    [Required]
    public ICollection<Language> Languages { get; set; }
}
