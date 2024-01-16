namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerApproval
{
    public int CustomerApprovalId { get; set; }

    public int CustomerId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
