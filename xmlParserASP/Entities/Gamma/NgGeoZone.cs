using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgGeoZone
{
    public int GeoZoneId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
