namespace xmlParserASP.Entities.TestGamma;

public partial class OcTaxClass
{
    public int TaxClassId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
