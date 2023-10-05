using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcOrderHistory
{
    public int OrderHistoryId { get; set; }

    public int OrderId { get; set; }

    public int OrderStatusId { get; set; }

    public bool Notify { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
