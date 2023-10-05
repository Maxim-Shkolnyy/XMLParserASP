using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcOption
{
    public int OptionId { get; set; }

    public string Type { get; set; } = null!;

    public int SortOrder { get; set; }
}
