namespace xmlParserASP.Entities.Gamma;

public partial class NgOptionValue
{
    public int OptionValueId { get; set; }

    public int OptionId { get; set; }

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
