﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcSeoTagsGenerator
{
    public int CategoryId { get; set; }

    public int LanguageId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}