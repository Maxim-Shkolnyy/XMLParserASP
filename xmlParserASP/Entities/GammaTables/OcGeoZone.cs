using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcGeoZone
{
    public int GeoZoneId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateModified { get; set; }

    public DateTime DateAdded { get; set; }
}
