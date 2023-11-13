namespace xmlParserASP.Entities.TestGamma;

public partial class OcCustomerReward
{
    public int CustomerRewardId { get; set; }

    public int CustomerId { get; set; }

    public int OrderId { get; set; }

    public string Description { get; set; } = null!;

    public int Points { get; set; }

    public DateTime DateAdded { get; set; }
}
