using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgArticleToBlogCategory
{
    public int ArticleId { get; set; }

    public int BlogCategoryId { get; set; }

    public bool MainBlogCategory { get; set; }
}
