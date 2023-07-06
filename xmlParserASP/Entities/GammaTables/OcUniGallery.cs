using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcUniGallery
{
    public int GalleryId { get; set; }

    public string Name { get; set; } = null!;

    public bool Status { get; set; }
}
