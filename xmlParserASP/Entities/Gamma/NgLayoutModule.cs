using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgLayoutModule
{
    public int LayoutModuleId { get; set; }

    public int LayoutId { get; set; }

    public string Code { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int SortOrder { get; set; }
}
