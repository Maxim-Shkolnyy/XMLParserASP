﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcTranslation
{
    public int TranslationId { get; set; }

    public int StoreId { get; set; }

    public int LanguageId { get; set; }

    public string Route { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}