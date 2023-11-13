namespace xmlParserASP.Entities.TestGamma;

public partial class OcLayoutModule
{
    public int LayoutModuleId { get; set; }

    public int LayoutId { get; set; }

    public string Code { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int SortOrder { get; set; }
}
