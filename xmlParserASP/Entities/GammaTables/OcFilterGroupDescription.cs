using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcFilterGroupDescription
{
    public int FilterGroupId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
