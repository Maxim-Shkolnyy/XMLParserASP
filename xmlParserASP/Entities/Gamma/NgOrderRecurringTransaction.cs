using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOrderRecurringTransaction
{
    public int OrderRecurringTransactionId { get; set; }

    public int OrderRecurringId { get; set; }

    public string Reference { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
