namespace xmlParserASP.Entities.GammaTables;

public partial class OcAffiliateTransaction
{
    public int AffiliateTransactionId { get; set; }

    public int AffiliateId { get; set; }

    public int OrderId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
