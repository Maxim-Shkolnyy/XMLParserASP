using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmSupplier
{
    [Key]
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;
}
