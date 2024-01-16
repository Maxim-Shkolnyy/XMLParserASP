namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterCache
{
    public ulong Key { get; set; }

    public string Value { get; set; } = null!;

    public string? Path { get; set; }

    public int Expire { get; set; }
}
