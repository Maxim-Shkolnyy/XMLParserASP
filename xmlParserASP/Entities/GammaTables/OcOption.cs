﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcOption
{
    public int OptionId { get; set; }

    public string Type { get; set; } = null!;

    public int SortOrder { get; set; }
}