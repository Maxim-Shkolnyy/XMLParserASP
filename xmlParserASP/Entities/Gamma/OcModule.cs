using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcModule
{
    public int ModuleId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Setting { get; set; } = null!;
}
