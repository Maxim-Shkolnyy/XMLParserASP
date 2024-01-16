namespace xmlParserASP.Entities.Gamma;

public partial class NgOrderHistory
{
    public int OrderHistoryId { get; set; }

    public int OrderId { get; set; }

    public int UserId { get; set; }

    public int OrderStatusId { get; set; }

    public string PaymentStatusId { get; set; } = null!;

    public string ShippingStatusId { get; set; } = null!;

    public bool Notify { get; set; }

    public bool NotifySms { get; set; }

    public bool NotifyTlgrm { get; set; }

    public string Comment { get; set; } = null!;

    public string Log { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
