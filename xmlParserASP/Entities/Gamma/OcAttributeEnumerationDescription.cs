using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcAttributeEnumerationDescription
{
    public int EnumerationId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
