namespace xmlParserASP.Entities.Gamma;

public partial class OcMarketing
{
    public int MarketingId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int Clicks { get; set; }

    public DateTime DateAdded { get; set; }
}
