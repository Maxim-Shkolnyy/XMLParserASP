using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class MaxOurAttr
{
    public int AttrId { get; set; }

    public int? AttrIdParrent { get; set; }

    public string? CatName { get; set; }

    public int? LangIndex { get; set; }
}
