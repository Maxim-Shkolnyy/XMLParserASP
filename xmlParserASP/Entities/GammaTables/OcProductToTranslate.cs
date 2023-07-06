using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcProductToTranslate
{
    public int TranslateId { get; set; }

    public int TransProductId { get; set; }

    public int TransStatus { get; set; }

    public DateTime TransDate { get; set; }
}
