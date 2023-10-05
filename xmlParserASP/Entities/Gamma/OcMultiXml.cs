using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcMultiXml
{
    public int XmlId { get; set; }

    public string Name { get; set; } = null!;

    public string Categories { get; set; } = null!;

    public string Products { get; set; } = null!;

    public string Suppliers { get; set; } = null!;

    public string Settings { get; set; } = null!;
}
