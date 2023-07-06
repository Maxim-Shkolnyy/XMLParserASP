using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerIp
{
    public int CustomerIpId { get; set; }

    public int CustomerId { get; set; }

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
