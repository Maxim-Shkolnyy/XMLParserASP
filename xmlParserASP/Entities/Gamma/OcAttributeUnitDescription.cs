using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcAttributeUnitDescription
{
    public int AttributeUnitId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
