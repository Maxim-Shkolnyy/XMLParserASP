namespace xmlParserASP.Entities.Gamma;

public partial class OcLanguage
{
    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Directory { get; set; } = null!;

    public int SortOrder { get; set; }

    public bool Status { get; set; }
}
