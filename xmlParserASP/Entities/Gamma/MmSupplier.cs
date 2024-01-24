using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.Gamma;

public partial class MmSupplier
{
    public int SupplierId { get; set; }

    [StringLength(20)]
    public string SupplierName { get; set; } = null!;
}
