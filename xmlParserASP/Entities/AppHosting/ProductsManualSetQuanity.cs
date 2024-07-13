using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class ProductsManualSetQuanity
{
    [Key]
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public decimal SetInStockQty { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
