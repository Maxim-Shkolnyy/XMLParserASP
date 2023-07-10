namespace xmlParserASP.Entities.GammaTables;

public partial class OcProductAttribute
{
    public int ProductId { get; set; }

    public int AttributeId { get; set; }

    public int LanguageId { get; set; }

    public string Text { get; set; } = null!;
}
