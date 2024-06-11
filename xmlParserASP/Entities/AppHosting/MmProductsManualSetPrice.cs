using System.ComponentModel.DataAnnotations;


namespace xmlParserASP.Entities.AppHosting;

public partial class MmProductsManualSetPrice
{
    [Key]
    public int Id { get; set; }

    [StringLength(7)]
    public string Sku { get; set; }

    public decimal SetInStockPrice { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
