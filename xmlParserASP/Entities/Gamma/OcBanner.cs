﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcBanner
{
    public int BannerId { get; set; }

    public string Name { get; set; } = null!;

    public bool Status { get; set; }
}