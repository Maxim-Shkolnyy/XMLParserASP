using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsCacheProduct
{
    public int ProductCacheId { get; set; }

    public int SendId { get; set; }

    public int CronId { get; set; }

    public string Type { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int Qty { get; set; }

    public string CatId { get; set; } = null!;

    public bool CatEach { get; set; }

    public string ProdId { get; set; } = null!;
}
