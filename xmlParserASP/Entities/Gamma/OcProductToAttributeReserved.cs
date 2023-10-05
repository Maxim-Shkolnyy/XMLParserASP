using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcProductToAttributeReserved
{
    public int ProductId { get; set; }

    public int AttributeId { get; set; }

    public int AttributableId { get; set; }

    public string AttributableType { get; set; } = null!;
}
