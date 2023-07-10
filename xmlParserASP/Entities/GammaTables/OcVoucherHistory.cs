namespace xmlParserASP.Entities.GammaTables;

public partial class OcVoucherHistory
{
    public int VoucherHistoryId { get; set; }

    public int VoucherId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
