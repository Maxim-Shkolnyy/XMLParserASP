using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOptionValue
{
    public int OptionValueId { get; set; }

    public int OptionId { get; set; }

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
