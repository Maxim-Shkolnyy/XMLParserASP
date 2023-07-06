using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcProductToCategory
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public bool MainCategory { get; set; }
}
