using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmProductsManualSetQuanity
{
    [Key]
    public int Id { get; set; }
    [StringLength(7)]
    public string Sku { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public int SetInStockQty { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
