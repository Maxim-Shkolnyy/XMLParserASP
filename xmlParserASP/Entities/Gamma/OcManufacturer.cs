using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcManufacturer
{
    public int ManufacturerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public int SortOrder { get; set; }
}
