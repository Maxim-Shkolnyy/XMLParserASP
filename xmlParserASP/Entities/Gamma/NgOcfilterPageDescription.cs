namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterPageDescription
{
    public uint PageId { get; set; }

    public byte LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string HeadingTitle { get; set; } = null!;

    public string MetaTitle { get; set; } = null!;

    public string MetaKeyword { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string DescriptionTop { get; set; } = null!;

    public string DescriptionBottom { get; set; } = null!;
}
