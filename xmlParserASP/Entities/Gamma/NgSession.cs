namespace xmlParserASP.Entities.Gamma;

public partial class NgSession
{
    public string SessionId { get; set; } = null!;

    public string Data { get; set; } = null!;

    public DateTime Expire { get; set; }
}
