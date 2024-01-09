using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgShippingCourier
{
    public int ShippingCourierId { get; set; }

    public string ShippingCourierCode { get; set; } = null!;

    public string ShippingCourierName { get; set; } = null!;
}
