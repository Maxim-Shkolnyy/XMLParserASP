using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcSupplerOption
{
    public int NomId { get; set; }

    public int? FormId { get; set; }

    public int? OptionId { get; set; }

    public string Opt { get; set; } = null!;

    public string OptPoint { get; set; } = null!;

    public string? Po { get; set; }

    public string Ko { get; set; } = null!;

    public string Pr { get; set; } = null!;

    public string? We { get; set; }

    public string? OptionRequired { get; set; }

    public string? Art { get; set; }

    public string? Foto { get; set; }

    public string? OptPref { get; set; }

    public string? OptMargin { get; set; }
}
