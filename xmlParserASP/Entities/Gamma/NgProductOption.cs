namespace xmlParserASP.Entities.Gamma;

public partial class NgProductOption
{
    public int ProductOptionId { get; set; }

    public int ProductId { get; set; }

    public int OptionId { get; set; }

    public string Value { get; set; } = null!;

    public bool Required { get; set; }
}
