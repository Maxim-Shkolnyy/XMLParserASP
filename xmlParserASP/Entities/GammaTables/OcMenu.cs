using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcMenu
{
    public int MenuId { get; set; }

    public int StoreId { get; set; }

    public string Type { get; set; } = null!;

    public string Link { get; set; } = null!;

    public int SortOrder { get; set; }

    public bool Status { get; set; }
}
