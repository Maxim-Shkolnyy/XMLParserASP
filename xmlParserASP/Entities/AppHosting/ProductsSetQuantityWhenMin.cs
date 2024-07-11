using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class ProductsSetQuantityWhenMin
{
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public int? MinQuantity { get; set; }

    public int SetQuantity { get; set; }
}
