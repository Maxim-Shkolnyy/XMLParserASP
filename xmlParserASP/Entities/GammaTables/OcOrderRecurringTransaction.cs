namespace xmlParserASP.Entities.GammaTables;

public partial class OcOrderRecurringTransaction
{
    public int OrderRecurringTransactionId { get; set; }

    public int OrderRecurringId { get; set; }

    public string Reference { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
