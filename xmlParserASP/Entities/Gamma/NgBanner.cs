using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgBanner
{
    public int BannerId { get; set; }

    public string Name { get; set; } = null!;

    public bool Status { get; set; }
}
