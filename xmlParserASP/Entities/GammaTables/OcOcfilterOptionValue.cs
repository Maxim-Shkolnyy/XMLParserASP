using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterOptionValue
{
    public long ValueId { get; set; }

    public int OptionId { get; set; }

    public string Keyword { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
