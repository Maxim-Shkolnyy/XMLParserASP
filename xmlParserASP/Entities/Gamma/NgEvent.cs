namespace xmlParserASP.Entities.Gamma;

public partial class NgEvent
{
    public int EventId { get; set; }

    public string Code { get; set; } = null!;

    public string Trigger { get; set; } = null!;

    public string Action { get; set; } = null!;

    public bool Status { get; set; }

    public int SortOrder { get; set; }
}
