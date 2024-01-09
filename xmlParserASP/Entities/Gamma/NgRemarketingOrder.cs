using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgRemarketingOrder
{
    public int OrderId { get; set; }

    public DateTime Ecommerce { get; set; }

    public DateTime EcommerceGa4 { get; set; }

    public DateTime Facebook { get; set; }

    public DateTime Esputnik { get; set; }

    public DateTime Telegram { get; set; }

    public DateTime Tiktok { get; set; }

    public DateTime FacebookLead { get; set; }

    public DateTime SuccessPage { get; set; }

    public string OrderData { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public string TtEventId { get; set; } = null!;

    public string FbLeadEventId { get; set; } = null!;

    public string FbEventId { get; set; } = null!;

    public string Ttclid { get; set; } = null!;

    public string UtmContent { get; set; } = null!;

    public string UtmTerm { get; set; } = null!;

    public string UtmMedium { get; set; } = null!;

    public string UtmCampaign { get; set; } = null!;

    public string UtmSource { get; set; } = null!;

    public string Dclid { get; set; } = null!;

    public string Gclid { get; set; } = null!;

    public string Fbp { get; set; } = null!;

    public string Fbc { get; set; } = null!;

    public string Fbclid { get; set; } = null!;

    public string Ga4Uuid { get; set; } = null!;

    public string Uuid { get; set; } = null!;
}
