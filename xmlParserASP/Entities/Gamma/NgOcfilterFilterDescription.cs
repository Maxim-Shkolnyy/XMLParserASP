using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterFilterDescription
{
    public uint FilterId { get; set; }

    public byte Source { get; set; }

    public byte LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Suffix { get; set; } = null!;

    public string Description { get; set; } = null!;
}
