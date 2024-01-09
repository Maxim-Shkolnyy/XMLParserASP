using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgSeoUrl
{
    public int SeoUrlId { get; set; }

    public int StoreId { get; set; }

    public int LanguageId { get; set; }

    public string Query { get; set; } = null!;

    public string Keyword { get; set; } = null!;
}
