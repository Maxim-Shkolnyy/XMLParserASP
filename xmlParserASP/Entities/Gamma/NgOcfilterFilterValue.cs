using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterFilterValue
{
    public ulong ValueId { get; set; }

    public byte Source { get; set; }

    public uint FilterId { get; set; }

    public ulong Key { get; set; }

    public string Color { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
