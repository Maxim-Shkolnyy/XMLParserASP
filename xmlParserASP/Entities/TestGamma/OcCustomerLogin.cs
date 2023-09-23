using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcCustomerLogin
{
    public int CustomerLoginId { get; set; }

    public string Email { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public int Total { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
