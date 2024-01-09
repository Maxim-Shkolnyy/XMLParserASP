using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgUniGalleryDescription
{
    public int GalleryId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string MetaKeyword { get; set; } = null!;
}
