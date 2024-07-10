using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class IdentityUserTokenString
{
    public string? UserId { get; set; }

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
