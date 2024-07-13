using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class ProductsSetQuantityWhenMin
{
    [Key]
    public int Id { get; set; }

    public string Sku { get; set; } = null!;

    public int? MinQuantity { get; set; }

    public int SetQuantity { get; set; }
}
