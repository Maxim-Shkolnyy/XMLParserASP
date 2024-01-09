using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgGoogleshoppingProductStatus
{
    public int ProductId { get; set; }

    public int StoreId { get; set; }

    public string ProductVariationId { get; set; } = null!;

    public string DestinationStatuses { get; set; } = null!;

    public string DataQualityIssues { get; set; } = null!;

    public string ItemLevelIssues { get; set; } = null!;

    public int GoogleExpirationDate { get; set; }
}
