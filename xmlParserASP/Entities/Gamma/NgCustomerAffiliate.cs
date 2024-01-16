namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerAffiliate
{
    public int CustomerId { get; set; }

    public string Company { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string Tracking { get; set; } = null!;

    public decimal Commission { get; set; }

    public string Tax { get; set; } = null!;

    public string Payment { get; set; } = null!;

    public string Cheque { get; set; } = null!;

    public string Paypal { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankBranchNumber { get; set; } = null!;

    public string BankSwiftCode { get; set; } = null!;

    public string BankAccountName { get; set; } = null!;

    public string BankAccountNumber { get; set; } = null!;

    public string CustomField { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }
}
