﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgTaxRate
{
    public int TaxRateId { get; set; }

    public int GeoZoneId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Rate { get; set; }

    public string Type { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
