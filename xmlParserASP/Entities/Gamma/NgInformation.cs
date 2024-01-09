using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgInformation
{
    public int InformationId { get; set; }

    public int Bottom { get; set; }

    public int SortOrder { get; set; }

    public bool? Status { get; set; }

    public bool? Noindex { get; set; }
}
