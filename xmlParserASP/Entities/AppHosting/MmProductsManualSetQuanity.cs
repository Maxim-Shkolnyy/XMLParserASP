using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmProductsManualSetQuanity
{
    public int Id { get; set; }
    [StringLength(7)]
    public string Sku { get; set; } = null!;

    public int SetInStockQty { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
