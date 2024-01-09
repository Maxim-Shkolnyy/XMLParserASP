using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgLicensesKm
{
    public int Id { get; set; }

    public string PCode { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string LicenseKey { get; set; } = null!;
}
