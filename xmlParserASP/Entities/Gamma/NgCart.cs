using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCart
{
    public uint CartId { get; set; }

    public int ApiId { get; set; }

    public int CustomerId { get; set; }

    public string SessionId { get; set; } = null!;

    public int ProductId { get; set; }

    public int RecurringId { get; set; }

    public string Option { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime DateAdded { get; set; }
}
