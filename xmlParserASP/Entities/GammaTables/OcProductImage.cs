using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcProductImage
{
    public int ProductImageId { get; set; }

    public int ProductId { get; set; }

    public string? Image { get; set; }

    public int SortOrder { get; set; }
}
