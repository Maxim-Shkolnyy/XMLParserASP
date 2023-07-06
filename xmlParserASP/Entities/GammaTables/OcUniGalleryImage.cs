using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcUniGalleryImage
{
    public int GalleryImageId { get; set; }

    public int GalleryId { get; set; }

    public string Name { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Image { get; set; } = null!;
}
