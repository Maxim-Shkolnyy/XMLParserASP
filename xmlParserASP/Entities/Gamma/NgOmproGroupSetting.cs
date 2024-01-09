using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOmproGroupSetting
{
    public int UserGroupId { get; set; }

    public string GroupTarget { get; set; } = null!;

    public string Pages { get; set; } = null!;

    public string AccessActions { get; set; } = null!;

    public string PaymentsList { get; set; } = null!;

    public string ShippingsList { get; set; } = null!;

    public string SelectOrders { get; set; } = null!;

    public string FiltersDefault { get; set; } = null!;

    public string OrderFormats { get; set; } = null!;

    public string ProductFormats { get; set; } = null!;

    public string OrderStatuses { get; set; } = null!;

    public string OrderPayments { get; set; } = null!;

    public string OrderShippings { get; set; } = null!;

    public string DaysToShip { get; set; } = null!;

    public string CommentTemplates { get; set; } = null!;
}
