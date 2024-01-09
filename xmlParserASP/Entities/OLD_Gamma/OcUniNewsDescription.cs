namespace xmlParserASP.Entities.Gamma;

public partial class OcUniNewsDescription
{
    public int NewsId { get; set; }

    public int LanguageId { get; set; }

    public string Title { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Keyword { get; set; } = null!;
}
