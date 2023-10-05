using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcUniGalleryImageDescription
{
    public int GalleryImageId { get; set; }

    public int LanguageId { get; set; }

    public int GalleryId { get; set; }

    public string Title { get; set; } = null!;
}
