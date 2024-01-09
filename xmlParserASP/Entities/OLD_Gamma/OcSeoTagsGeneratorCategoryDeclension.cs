namespace xmlParserASP.Entities.Gamma;

public partial class OcSeoTagsGeneratorCategoryDeclension
{
    public int CategoryId { get; set; }

    public int LanguageId { get; set; }

    public string CategoryNamePluralNominative { get; set; } = null!;

    public string CategoryNameSingularNominative { get; set; } = null!;

    public string CategoryNamePluralGenitive { get; set; } = null!;
}
