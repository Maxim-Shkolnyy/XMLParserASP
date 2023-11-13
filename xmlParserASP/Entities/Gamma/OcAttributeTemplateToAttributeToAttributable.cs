namespace xmlParserASP.Entities.Gamma;

public partial class OcAttributeTemplateToAttributeToAttributable
{
    public int AttributeTemplateId { get; set; }

    public int AttributeId { get; set; }

    public int AttributableId { get; set; }

    public string AttributableType { get; set; } = null!;

    public int SortOrder { get; set; }
}
