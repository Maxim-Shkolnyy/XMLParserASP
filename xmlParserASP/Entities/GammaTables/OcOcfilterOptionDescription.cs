﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcOcfilterOptionDescription
{
    public int OptionId { get; set; }

    public sbyte LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Postfix { get; set; } = null!;

    public string Description { get; set; } = null!;
}