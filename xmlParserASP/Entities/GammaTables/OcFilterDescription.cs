﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcFilterDescription
{
    public int FilterId { get; set; }

    public int LanguageId { get; set; }

    public int FilterGroupId { get; set; }

    public string Name { get; set; } = null!;
}