using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcStockStatus
{
    public int StockStatusId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
