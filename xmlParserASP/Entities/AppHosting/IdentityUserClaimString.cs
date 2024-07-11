using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class IdentityUserClaimString
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }
}
