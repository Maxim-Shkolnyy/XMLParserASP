using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcMultiplicityProduct
{
    public int ProductId { get; set; }

    public string Description { get; set; } = null!;

    public int Step { get; set; }
}
