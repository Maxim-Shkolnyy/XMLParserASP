using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerTransaction
{
    public int CustomerTransactionId { get; set; }

    public int CustomerId { get; set; }

    public int OrderId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
