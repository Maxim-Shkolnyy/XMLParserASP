namespace xmlParserASP.Entities.TestGamma;

public partial class OcTaxRule
{
    public int TaxRuleId { get; set; }

    public int TaxClassId { get; set; }

    public int TaxRateId { get; set; }

    public string Based { get; set; } = null!;

    public int Priority { get; set; }
}
