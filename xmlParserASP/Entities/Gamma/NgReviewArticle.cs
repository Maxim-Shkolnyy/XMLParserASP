namespace xmlParserASP.Entities.Gamma;

public partial class NgReviewArticle
{
    public int ReviewArticleId { get; set; }

    public int ArticleId { get; set; }

    public int CustomerId { get; set; }

    public string Author { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int Rating { get; set; }

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
