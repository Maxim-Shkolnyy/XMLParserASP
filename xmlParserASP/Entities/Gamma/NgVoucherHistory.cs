using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgVoucherHistory
{
    public int VoucherHistoryId { get; set; }

    public int VoucherId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
