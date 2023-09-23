using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcAttributeEnumDescription
{
    public int EnumId { get; set; }

    public int EnumerationId { get; set; }

    public int LanguageId { get; set; }

    public string Text { get; set; } = null!;
}
