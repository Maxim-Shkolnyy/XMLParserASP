namespace xmlParserASP.Entities.GammaTables;

public partial class OcUrlAliasBlog
{
    public int UrlAliasId { get; set; }

    public string Query { get; set; } = null!;

    public string Keyword { get; set; } = null!;

    public int LanguageId { get; set; }
}
