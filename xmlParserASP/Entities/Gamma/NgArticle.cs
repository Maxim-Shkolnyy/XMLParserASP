namespace xmlParserASP.Entities.Gamma;

public partial class NgArticle
{
    public int ArticleId { get; set; }

    public string? Image { get; set; }

    public DateTime DateAvailable { get; set; }

    public int SortOrder { get; set; }

    public bool ArticleReview { get; set; }

    public bool Status { get; set; }

    public bool? Noindex { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }

    public int Viewed { get; set; }

    public int Gstatus { get; set; }
}
