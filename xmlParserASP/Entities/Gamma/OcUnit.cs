﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcUnit
{
    public int UnitId { get; set; }

    public int Code { get; set; }

    public string Title { get; set; } = null!;

    public string? SymbolRus { get; set; }

    public string? SymbolIntl { get; set; }

    public string? SymbolLetterIntl { get; set; }
}