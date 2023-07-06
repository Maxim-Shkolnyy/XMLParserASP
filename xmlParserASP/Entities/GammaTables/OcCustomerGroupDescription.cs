using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerGroupDescription
{
    public int CustomerGroupId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
