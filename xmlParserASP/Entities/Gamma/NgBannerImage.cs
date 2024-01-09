using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgBannerImage
{
    public int BannerImageId { get; set; }

    public int BannerId { get; set; }

    public int LanguageId { get; set; }

    public string Title { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
