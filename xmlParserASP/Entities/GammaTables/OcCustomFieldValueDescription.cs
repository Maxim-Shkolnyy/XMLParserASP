namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomFieldValueDescription
{
    public int CustomFieldValueId { get; set; }

    public int LanguageId { get; set; }

    public int CustomFieldId { get; set; }

    public string Name { get; set; } = null!;
}
