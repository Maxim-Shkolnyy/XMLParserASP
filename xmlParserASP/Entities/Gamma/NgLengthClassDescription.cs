using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgLengthClassDescription
{
    public int LengthClassId { get; set; }

    public int LanguageId { get; set; }

    public string Title { get; set; } = null!;

    public string Unit { get; set; } = null!;
}
