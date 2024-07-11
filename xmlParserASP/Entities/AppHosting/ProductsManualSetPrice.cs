using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class ProductsManualSetPrice
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public decimal SetInStockPrice { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
