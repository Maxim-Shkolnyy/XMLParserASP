using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOrderShipment
{
    public int OrderShipmentId { get; set; }

    public int OrderId { get; set; }

    public DateTime DateAdded { get; set; }

    public string ShippingCourierId { get; set; } = null!;

    public string TrackingNumber { get; set; } = null!;
}
