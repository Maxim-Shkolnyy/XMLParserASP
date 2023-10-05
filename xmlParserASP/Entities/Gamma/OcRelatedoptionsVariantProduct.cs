using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcRelatedoptionsVariantProduct
{
    public int RelatedoptionsVariantProductId { get; set; }

    public int? RelatedoptionsVariantId { get; set; }

    public int? ProductId { get; set; }

    public bool? RelatedoptionsUse { get; set; }
}
