using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomMenu
{
    public int MenuId { get; set; }

    public string? Link { get; set; }

    public string? Image { get; set; }

    public int? ParentId { get; set; }

    public int? ParentParentId { get; set; }

    public int? Status { get; set; }

    public int? Column { get; set; }

    public int? SortOrder { get; set; }
}
