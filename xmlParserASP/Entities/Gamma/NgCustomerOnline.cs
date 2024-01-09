using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerOnline
{
    public string Ip { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Url { get; set; } = null!;

    public string Referer { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
