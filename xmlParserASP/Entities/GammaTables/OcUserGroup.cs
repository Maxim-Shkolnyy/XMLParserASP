using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcUserGroup
{
    public int UserGroupId { get; set; }

    public string Name { get; set; } = null!;

    public string Permission { get; set; } = null!;
}
