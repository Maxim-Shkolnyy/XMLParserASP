namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsUnsubscribe
{
    public int UnsubscribeId { get; set; }

    public int SendId { get; set; }

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
