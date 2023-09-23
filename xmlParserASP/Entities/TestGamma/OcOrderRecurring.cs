using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcOrderRecurring
{
    public int OrderRecurringId { get; set; }

    public int OrderId { get; set; }

    public string Reference { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int ProductQuantity { get; set; }

    public int RecurringId { get; set; }

    public string RecurringName { get; set; } = null!;

    public string RecurringDescription { get; set; } = null!;

    public string RecurringFrequency { get; set; } = null!;

    public short RecurringCycle { get; set; }

    public short RecurringDuration { get; set; }

    public decimal RecurringPrice { get; set; }

    public bool Trial { get; set; }

    public string TrialFrequency { get; set; } = null!;

    public short TrialCycle { get; set; }

    public short TrialDuration { get; set; }

    public decimal TrialPrice { get; set; }

    public sbyte Status { get; set; }

    public DateTime DateAdded { get; set; }
}
