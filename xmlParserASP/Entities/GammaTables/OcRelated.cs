using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcRelated
{
    public int RelatedId { get; set; }

    public int? ProductId { get; set; }

    public string? RelatedTitle { get; set; }

    public string? RelatedProductStrId { get; set; }
}
