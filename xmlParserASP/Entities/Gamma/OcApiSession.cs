namespace xmlParserASP.Entities.Gamma;

public partial class OcApiSession
{
    public int ApiSessionId { get; set; }

    public int ApiId { get; set; }

    public string Token { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string SessionName { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
