using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOrderProduct
{
    public int OrderProductId { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Purchase { get; set; }

    public decimal Price { get; set; }

    public decimal Total { get; set; }

    public decimal Tax { get; set; }

    public int Reward { get; set; }

    public string Notes { get; set; } = null!;
}
