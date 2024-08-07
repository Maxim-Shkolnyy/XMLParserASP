﻿using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.AppHosting;

public partial class MmProductsSetQuantityWhenMin
{
    [Key]
    public int Id { get; set; }
    [StringLength(7)]
    public string Sku { get; set; } = null!;

    public int? MinQuantity { get; set; }

    public int SetQuantity { get; set; }
}