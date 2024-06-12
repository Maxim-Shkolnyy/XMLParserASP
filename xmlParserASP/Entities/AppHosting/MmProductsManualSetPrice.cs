using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace xmlParserASP.Entities.AppHosting;

public partial class MmProductsManualSetPrice
{
    [Key]
    public int Id { get; set; }

    [StringLength(7)]
    public string Sku { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SetInStockPrice { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
