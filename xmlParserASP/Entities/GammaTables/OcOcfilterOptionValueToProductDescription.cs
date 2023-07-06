using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterOptionValueToProductDescription
{
    public int ProductId { get; set; }

    public long ValueId { get; set; }

    public int OptionId { get; set; }

    public sbyte LanguageId { get; set; }

    public string Description { get; set; } = null!;
}
