using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerHistory
{
    public int CustomerHistoryId { get; set; }

    public int CustomerId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
