namespace xmlParserASP.Entities.TestGamma;

public partial class OcAffiliate
{
    public int AffiliateId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public int CountryId { get; set; }

    public int ZoneId { get; set; }

    public string Code { get; set; } = null!;

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

    public string Ip { get; set; } = null!;

    public bool Status { get; set; }

    public bool Approved { get; set; }

    public DateTime DateAdded { get; set; }
}
