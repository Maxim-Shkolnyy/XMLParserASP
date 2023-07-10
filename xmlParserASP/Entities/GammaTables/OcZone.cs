namespace xmlParserASP.Entities.GammaTables;

public partial class OcZone
{
    public int ZoneId { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public bool? Status { get; set; }
}
