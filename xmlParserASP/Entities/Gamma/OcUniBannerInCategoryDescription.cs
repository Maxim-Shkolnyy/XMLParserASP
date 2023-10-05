using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcUniBannerInCategoryDescription
{
    public int BannerId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Button { get; set; } = null!;

    public string Link { get; set; } = null!;
}
