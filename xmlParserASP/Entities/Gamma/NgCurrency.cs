﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgCurrency
{
    public int CurrencyId { get; set; }

    public string Title { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string SymbolLeft { get; set; } = null!;

    public string SymbolRight { get; set; } = null!;

    public string DecimalPlace { get; set; } = null!;

    public double Value { get; set; }

    public bool Status { get; set; }

    public DateTime DateModified { get; set; }
}
