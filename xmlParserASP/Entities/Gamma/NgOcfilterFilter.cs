using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterFilter
{
    public uint FilterId { get; set; }

    public byte Source { get; set; }

    public string Type { get; set; } = null!;

    public bool Dropdown { get; set; }

    public bool Color { get; set; }

    public bool Image { get; set; }

    public bool Status { get; set; }

    public int SortOrder { get; set; }
}
