﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcCountry
{
    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string IsoCode2 { get; set; } = null!;

    public string IsoCode3 { get; set; } = null!;

    public string AddressFormat { get; set; } = null!;

    public bool PostcodeRequired { get; set; }

    public bool? Status { get; set; }
}