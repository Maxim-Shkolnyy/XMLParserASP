using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmSupplier
{
    [Key]
    public int SupplierId { get; set; }

    [StringLength(20)]
    public string SupplierName { get; set; } = null!;
}
