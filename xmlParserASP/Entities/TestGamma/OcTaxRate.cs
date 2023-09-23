using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcTaxRate
{
    public int TaxRateId { get; set; }

    public int GeoZoneId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Rate { get; set; }

    public string Type { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
