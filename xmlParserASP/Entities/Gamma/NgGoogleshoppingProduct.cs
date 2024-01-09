using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgGoogleshoppingProduct
{
    public uint ProductAdvertiseGoogleId { get; set; }

    public int? ProductId { get; set; }

    public int StoreId { get; set; }

    public bool? HasIssues { get; set; }

    public string DestinationStatus { get; set; } = null!;

    public int Impressions { get; set; }

    public int Clicks { get; set; }

    public int Conversions { get; set; }

    public decimal Cost { get; set; }

    public decimal ConversionValue { get; set; }

    public string? GoogleProductCategory { get; set; }

    public string? Condition { get; set; }

    public bool? Adult { get; set; }

    public int? Multipack { get; set; }

    public bool? IsBundle { get; set; }

    public string? AgeGroup { get; set; }

    public int? Color { get; set; }

    public string? Gender { get; set; }

    public string? SizeType { get; set; }

    public string? SizeSystem { get; set; }

    public int? Size { get; set; }

    public bool IsModified { get; set; }
}
