namespace xmlParserASP.Entities.TestGamma;

public partial class OcOcfilterOption
{
    public int OptionId { get; set; }

    public string Type { get; set; } = null!;

    public string Keyword { get; set; } = null!;

    public bool Selectbox { get; set; }

    public sbyte Grouping { get; set; }

    public bool Color { get; set; }

    public bool Image { get; set; }

    public bool? Status { get; set; }

    public int SortOrder { get; set; }
}
