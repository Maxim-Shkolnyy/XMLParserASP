﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgTranslation
{
    public int TranslationId { get; set; }

    public int StoreId { get; set; }

    public int LanguageId { get; set; }

    public string Route { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
