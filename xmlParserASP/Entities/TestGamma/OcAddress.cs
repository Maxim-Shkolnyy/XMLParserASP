using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcAddress
{
    public int AddressId { get; set; }

    public int CustomerId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Postcode { get; set; } = null!;

    public int CountryId { get; set; }

    public int ZoneId { get; set; }

    public string CustomField { get; set; } = null!;
}
