namespace xmlParserASP.Entities.TestGamma;

public partial class OcUser
{
    public int UserId { get; set; }

    public int UserGroupId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }
}
