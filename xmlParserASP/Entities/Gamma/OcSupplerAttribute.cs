namespace xmlParserASP.Entities.Gamma;

public partial class OcSupplerAttribute
{
    public int NomId { get; set; }

    public int? FormId { get; set; }

    public string AttrExt { get; set; } = null!;

    public string AttrPoint { get; set; } = null!;

    public int? AttributeId { get; set; }

    public string? Tags { get; set; }

    public int? FilterGroupId { get; set; }
}
