namespace xmlParserASP.Entities.Gamma;

public partial class OcSupplerRef
{
    public int NomId { get; set; }

    public int? ProductId { get; set; }

    public string Ident { get; set; } = null!;

    public string? Url { get; set; }

    public decimal? Price { get; set; }
}
