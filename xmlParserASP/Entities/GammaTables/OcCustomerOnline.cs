using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerOnline
{
    public string Ip { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Url { get; set; } = null!;

    public string Referer { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
