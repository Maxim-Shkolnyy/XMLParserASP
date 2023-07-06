using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcSupplerPrice
{
    public int NomId { get; set; }

    public int? FormId { get; set; }

    public string? Nom { get; set; }

    public string Ident { get; set; } = null!;

    public decimal? Mratek { get; set; }

    public string? Param { get; set; }

    public string Point { get; set; } = null!;

    public string Noprice { get; set; } = null!;

    public string? Paramnp { get; set; }

    public string Pointnp { get; set; } = null!;

    public int? Baseprice { get; set; }
}
