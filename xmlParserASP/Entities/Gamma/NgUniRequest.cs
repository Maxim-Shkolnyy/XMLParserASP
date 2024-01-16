namespace xmlParserASP.Entities.Gamma;

public partial class NgUniRequest
{
    public int RequestId { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public int ProductId { get; set; }

    public string Comment { get; set; } = null!;

    public string AdminComment { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }

    public bool? Status { get; set; }

    public bool RequestList { get; set; }
}
