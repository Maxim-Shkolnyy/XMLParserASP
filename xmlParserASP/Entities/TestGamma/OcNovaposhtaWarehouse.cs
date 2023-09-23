using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcNovaposhtaWarehouse
{
    public int SiteKey { get; set; }

    public string Ref { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string DescriptionRu { get; set; } = null!;

    public string ShortAddress { get; set; } = null!;

    public string ShortAddressRu { get; set; } = null!;

    public string TypeOfWarehouse { get; set; } = null!;

    public string CityRef { get; set; } = null!;

    public string CityDescription { get; set; } = null!;

    public string CityDescriptionRu { get; set; } = null!;

    public int Number { get; set; }

    public string Phone { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public bool PostFinance { get; set; }

    public bool BicycleParking { get; set; }

    public bool PaymentAccess { get; set; }

    public bool Posterminal { get; set; }

    public bool InternationalShipping { get; set; }

    public int TotalMaxWeightAllowed { get; set; }

    public int PlaceMaxWeightAllowed { get; set; }

    public string Reception { get; set; } = null!;

    public string Delivery { get; set; } = null!;

    public string Schedule { get; set; } = null!;

    public string DistrictCode { get; set; } = null!;

    public string WarehouseStatus { get; set; } = null!;

    public string CategoryOfWarehouse { get; set; } = null!;
}
