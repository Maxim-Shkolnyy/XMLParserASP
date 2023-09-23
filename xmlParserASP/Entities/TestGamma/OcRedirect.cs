using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcRedirect
{
    public int RedirectId { get; set; }

    public bool? Active { get; set; }

    public string? FromUrl { get; set; }

    public string? ToUrl { get; set; }

    public int? ResponseCode { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? TimesUsed { get; set; }

    public int? ProductId { get; set; }
}
