using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOptionDescription
{
    public int OptionId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
