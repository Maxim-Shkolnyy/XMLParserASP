namespace xmlParserASP.Entities.Gamma;

public partial class OcLocation
{
    public int LocationId { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Geocode { get; set; } = null!;

    public string? Image { get; set; }

    public string Open { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
