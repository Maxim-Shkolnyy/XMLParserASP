namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerSearch
{
    public int CustomerSearchId { get; set; }

    public int StoreId { get; set; }

    public int LanguageId { get; set; }

    public int CustomerId { get; set; }

    public string Keyword { get; set; } = null!;

    public int? CategoryId { get; set; }

    public bool SubCategory { get; set; }

    public bool Description { get; set; }

    public int Products { get; set; }

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
