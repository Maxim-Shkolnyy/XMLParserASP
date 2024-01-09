using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgArticleImage
{
    public int ArticleImageId { get; set; }

    public int ArticleId { get; set; }

    public string? Image { get; set; }

    public int SortOrder { get; set; }
}
