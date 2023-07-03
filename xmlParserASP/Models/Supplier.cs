using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLparser.TablesModels;

public class Supplier
{
    [Key]
    [Required]
    public int SupplierId {get; set;}
    
    public int SupplierName { get; set; }

}
