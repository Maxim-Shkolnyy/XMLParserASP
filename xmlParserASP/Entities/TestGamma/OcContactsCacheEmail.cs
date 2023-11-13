namespace xmlParserASP.Entities.TestGamma;

public partial class OcContactsCacheEmail
{
    public int EmailId { get; set; }

    public int SendId { get; set; }

    public string Email { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Zone { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
