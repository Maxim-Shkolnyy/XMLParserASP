using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOrderTotal
{
    public int OrderTotalId { get; set; }

    public int OrderId { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal Value { get; set; }

    public int SortOrder { get; set; }
}
