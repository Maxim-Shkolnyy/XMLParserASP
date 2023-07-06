using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerActivity
{
    public int CustomerActivityId { get; set; }

    public int CustomerId { get; set; }

    public string Key { get; set; } = null!;

    public string Data { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
