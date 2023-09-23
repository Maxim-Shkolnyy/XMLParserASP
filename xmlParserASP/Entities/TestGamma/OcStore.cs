using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcStore
{
    public int StoreId { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Ssl { get; set; } = null!;
}
