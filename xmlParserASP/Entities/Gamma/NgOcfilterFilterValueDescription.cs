namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterFilterValueDescription
{
    public ulong ValueId { get; set; }

    public byte Source { get; set; }

    public byte LanguageId { get; set; }

    public uint FilterId { get; set; }

    public string Name { get; set; } = null!;

    public string AttributeText { get; set; } = null!;
}
