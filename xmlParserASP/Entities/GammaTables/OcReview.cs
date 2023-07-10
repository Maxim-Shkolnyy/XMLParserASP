namespace xmlParserASP.Entities.GammaTables;

public partial class OcReview
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public string Author { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string AdminReply { get; set; } = null!;

    public string Minus { get; set; } = null!;

    public string Plus { get; set; } = null!;

    public int Rating { get; set; }

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
