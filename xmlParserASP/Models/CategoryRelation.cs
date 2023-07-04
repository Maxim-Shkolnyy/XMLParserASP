using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace xmlParserASP.Models;


[PrimaryKey(nameof(MyCatId), nameof(SupplierCatId), nameof(SupplierId), nameof(LanguageId))]
public class CategoryRelation
{
    public int MyCatId { get; set; }
    public int SupplierCatId { get; set; }
    public int SupplierId { get; set; }
    public int LanguageId { get; set; }
}
