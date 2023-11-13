namespace xmlParserASP.Entities.TestGamma;

public partial class OcCouponHistory
{
    public int CouponHistoryId { get; set; }

    public int CouponId { get; set; }

    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime DateAdded { get; set; }
}
