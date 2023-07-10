namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterOptionValueToProduct
{
    public int OcfilterOptionValueToProductId { get; set; }

    public int ProductId { get; set; }

    public int OptionId { get; set; }

    public long ValueId { get; set; }

    public decimal SlideValueMin { get; set; }

    public decimal SlideValueMax { get; set; }
}
