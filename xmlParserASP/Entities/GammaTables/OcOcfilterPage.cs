using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterPage
{
    public int OcfilterPageId { get; set; }

    public int CategoryId { get; set; }

    public string Keyword { get; set; } = null!;

    public string Params { get; set; } = null!;

    public string Over { get; set; } = null!;

    public bool? Status { get; set; }
}
