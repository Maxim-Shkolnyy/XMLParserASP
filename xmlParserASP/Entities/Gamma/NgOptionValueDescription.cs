﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOptionValueDescription
{
    public int OptionValueId { get; set; }

    public int LanguageId { get; set; }

    public int OptionId { get; set; }

    public string Name { get; set; } = null!;
}