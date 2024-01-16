namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterPage
{
    public uint PageId { get; set; }

    public uint CategoryId { get; set; }

    public uint DynamicId { get; set; }

    public ulong ParamsKey { get; set; }

    public byte ParamsCount { get; set; }

    public string Params { get; set; } = null!;

    public bool Dynamic { get; set; }

    public bool Module { get; set; }

    public bool Sitemap { get; set; }

    public bool Category { get; set; }

    public bool Product { get; set; }

    public bool Status { get; set; }
}
