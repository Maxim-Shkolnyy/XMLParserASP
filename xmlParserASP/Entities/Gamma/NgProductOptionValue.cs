namespace xmlParserASP.Entities.Gamma;

public partial class NgProductOptionValue
{
    public int ProductOptionValueId { get; set; }

    public int ProductOptionId { get; set; }

    public int ProductId { get; set; }

    public int OptionId { get; set; }

    public int OptionValueId { get; set; }

    public int Quantity { get; set; }

    public bool Subtract { get; set; }

    public decimal Price { get; set; }

    public string PricePrefix { get; set; } = null!;

    public int Points { get; set; }

    public string PointsPrefix { get; set; } = null!;

    public decimal Weight { get; set; }

    public string WeightPrefix { get; set; } = null!;
}
