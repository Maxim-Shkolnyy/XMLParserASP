using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcSupplerSkuDescription
{
    public int NomId { get; set; }

    public int? SkuId { get; set; }

    public string Sku { get; set; } = null!;

    public int? StoreId { get; set; }
}
