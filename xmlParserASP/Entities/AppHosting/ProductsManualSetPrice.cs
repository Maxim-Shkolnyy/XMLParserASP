using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class ProductsManualSetPrice
{
    [Key]
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public decimal SetInStockPrice { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
