using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerHistory
{
    public int CustomerHistoryId { get; set; }

    public int CustomerId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
