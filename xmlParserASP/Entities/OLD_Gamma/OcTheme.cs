namespace xmlParserASP.Entities.Gamma;

public partial class OcTheme
{
    public int ThemeId { get; set; }

    public int StoreId { get; set; }

    public string Theme { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
