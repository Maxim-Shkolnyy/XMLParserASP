using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcAttributableToAttribute
{
    public int AttributableId { get; set; }

    public string AttributableType { get; set; } = null!;

    public int AttributeId { get; set; }
}
