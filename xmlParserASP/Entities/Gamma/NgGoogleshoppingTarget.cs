using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgGoogleshoppingTarget
{
    public uint AdvertiseGoogleTargetId { get; set; }

    public int StoreId { get; set; }

    public string CampaignName { get; set; } = null!;

    public string Country { get; set; } = null!;

    public decimal Budget { get; set; }

    public string Feeds { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? DateAdded { get; set; }

    public int Roas { get; set; }
}
