﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcUrlAlias
{
    public int UrlAliasId { get; set; }

    public string Query { get; set; } = null!;

    public string Keyword { get; set; } = null!;
}