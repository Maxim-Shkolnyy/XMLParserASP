using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOrderStatus
{
    public int OrderStatusId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
