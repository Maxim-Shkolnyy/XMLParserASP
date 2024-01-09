using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgExtension
{
    public int ExtensionId { get; set; }

    public string Type { get; set; } = null!;

    public string Code { get; set; } = null!;
}
