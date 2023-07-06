using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterOptionValueDescription
{
    public long ValueId { get; set; }

    public int OptionId { get; set; }

    public sbyte LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
