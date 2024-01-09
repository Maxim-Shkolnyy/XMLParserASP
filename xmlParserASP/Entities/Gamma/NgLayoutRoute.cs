using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgLayoutRoute
{
    public int LayoutRouteId { get; set; }

    public int LayoutId { get; set; }

    public int StoreId { get; set; }

    public string Route { get; set; } = null!;
}
