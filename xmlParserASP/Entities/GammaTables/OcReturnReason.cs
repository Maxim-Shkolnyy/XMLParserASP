using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcReturnReason
{
    public int ReturnReasonId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
