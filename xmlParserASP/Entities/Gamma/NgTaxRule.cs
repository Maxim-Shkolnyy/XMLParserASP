namespace xmlParserASP.Entities.Gamma;

public partial class NgTaxRule
{
    public int TaxRuleId { get; set; }

    public int TaxClassId { get; set; }

    public int TaxRateId { get; set; }

    public string Based { get; set; } = null!;

    public int Priority { get; set; }
}
