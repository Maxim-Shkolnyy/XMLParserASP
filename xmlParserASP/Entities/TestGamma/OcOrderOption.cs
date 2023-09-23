using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcOrderOption
{
    public int OrderOptionId { get; set; }

    public int OrderId { get; set; }

    public int OrderProductId { get; set; }

    public int ProductOptionId { get; set; }

    public int ProductOptionValueId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Type { get; set; } = null!;
}
