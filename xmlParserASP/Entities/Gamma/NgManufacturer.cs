﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgManufacturer
{
    public int ManufacturerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public int SortOrder { get; set; }

    public bool? Noindex { get; set; }
}
