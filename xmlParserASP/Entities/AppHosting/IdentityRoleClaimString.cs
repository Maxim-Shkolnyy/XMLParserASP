using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.AppHosting;

public partial class IdentityRoleClaimString
{
    public int Id { get; set; }

    public string? RoleId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }
}
