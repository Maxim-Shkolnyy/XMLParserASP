namespace xmlParserASP.Entities.Gamma;

public partial class OcContactsCronEmail
{
    public int CemailId { get; set; }

    public int CronId { get; set; }

    public string Email { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Zone { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public bool CheckStatus { get; set; }

    public string CheckText { get; set; } = null!;
}
