using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgZone
{
    public int ZoneId { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public bool? Status { get; set; }
}
