using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerIp
{
    public int CustomerIpId { get; set; }

    public int CustomerId { get; set; }

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
