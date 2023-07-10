namespace xmlParserASP.Entities.GammaTables;

public partial class OcEvent
{
    public int EventId { get; set; }

    public string Code { get; set; } = null!;

    public string Trigger { get; set; } = null!;

    public string Action { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }

    public int SortOrder { get; set; }
}
