﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgAttributeDescription
{
    public int AttributeId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}