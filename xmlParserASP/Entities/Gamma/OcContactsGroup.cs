﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcContactsGroup
{
    public int GroupId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}