namespace xmlParserASP.Entities.Gamma;

public partial class NgSeoTagsGeneratorCategoryDeclension
{
    public int CategoryId { get; set; }

    public int LanguageId { get; set; }

    public string CategoryNameSingularNominative { get; set; } = null!;

    public string CategoryNameSingularGenitive { get; set; } = null!;

    public string CategoryNamePluralNominative { get; set; } = null!;

    public string CategoryNamePluralGenitive { get; set; } = null!;
}
