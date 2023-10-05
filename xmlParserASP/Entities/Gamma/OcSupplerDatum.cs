using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcSupplerDatum
{
    public int NomId { get; set; }

    public int? FormId { get; set; }

    public string CatExt { get; set; } = null!;

    public int? CategoryId { get; set; }

    public string PicInt { get; set; } = null!;

    public string CatPlus { get; set; } = null!;
}
