using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcLengthClassDescription
{
    public int LengthClassId { get; set; }

    public int LanguageId { get; set; }

    public string Title { get; set; } = null!;

    public string Unit { get; set; } = null!;
}
