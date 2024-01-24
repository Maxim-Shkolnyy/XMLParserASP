using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace xmlParserASP.Entities.Gamma;

public partial class ProductsManualSetPrice
{
    [Key]
    public int Id { get; set; }

    [StringLength(7)]
    public string Sku { get; set; }

    public decimal SetInStockPrice { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
