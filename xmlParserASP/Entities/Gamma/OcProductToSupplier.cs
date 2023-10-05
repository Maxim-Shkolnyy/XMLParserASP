using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcProductToSupplier
{
    public int ProductId { get; set; }

    public string SupplierId { get; set; } = null!;
}
