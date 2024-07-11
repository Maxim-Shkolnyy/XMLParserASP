using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class IdentityRole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }
}
