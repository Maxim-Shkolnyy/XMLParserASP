using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgStore
{
    public int StoreId { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Ssl { get; set; } = null!;
}
