using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcNixSupplier
{
    public uint SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string LinkPrice { get; set; } = null!;

    public string Tags { get; set; } = null!;

    public string Attributes { get; set; } = null!;
}
