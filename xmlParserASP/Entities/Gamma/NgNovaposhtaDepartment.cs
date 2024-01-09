using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgNovaposhtaDepartment
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

    public string SettlementRef { get; set; } = null!;

    public string SettlementDescription { get; set; } = null!;

    public string SettlementAreaDescription { get; set; } = null!;

    public string SettlementRegionsDescription { get; set; } = null!;

    public string SettlementTypeDescription { get; set; } = null!;

    public int Number { get; set; }

    public string Phone { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public bool PostFinance { get; set; }

    public bool BicycleParking { get; set; }

    public bool PaymentAccess { get; set; }

    public bool Posterminal { get; set; }

    public bool InternationalShipping { get; set; }

    public bool SelfServiceWorkplacesCount { get; set; }

    public int TotalMaxWeightAllowed { get; set; }

    public int PlaceMaxWeightAllowed { get; set; }

    public int SendingLimitationsOnDimensionsLength { get; set; }

    public int SendingLimitationsOnDimensionsWidth { get; set; }

    public int SendingLimitationsOnDimensionsHeight { get; set; }

    public int ReceivingLimitationsOnDimensionsLength { get; set; }

    public int ReceivingLimitationsOnDimensionsWidth { get; set; }

    public int ReceivingLimitationsOnDimensionsHeight { get; set; }

    public string ReceptionMonday { get; set; } = null!;

    public string ReceptionTuesday { get; set; } = null!;

    public string ReceptionWednesday { get; set; } = null!;

    public string ReceptionThursday { get; set; } = null!;

    public string ReceptionFriday { get; set; } = null!;

    public string ReceptionSaturday { get; set; } = null!;

    public string ReceptionSunday { get; set; } = null!;

    public string DeliveryMonday { get; set; } = null!;

    public string DeliveryTuesday { get; set; } = null!;

    public string DeliveryWednesday { get; set; } = null!;

    public string DeliveryThursday { get; set; } = null!;

    public string DeliveryFriday { get; set; } = null!;

    public string DeliverySaturday { get; set; } = null!;

    public string DeliverySunday { get; set; } = null!;

    public string ScheduleMonday { get; set; } = null!;

    public string ScheduleTuesday { get; set; } = null!;

    public string ScheduleWednesday { get; set; } = null!;

    public string ScheduleThursday { get; set; } = null!;

    public string ScheduleFriday { get; set; } = null!;

    public string ScheduleSaturday { get; set; } = null!;

    public string ScheduleSunday { get; set; } = null!;

    public string DistrictCode { get; set; } = null!;

    public string WarehouseStatus { get; set; } = null!;

    public string WarehouseStatusDate { get; set; } = null!;

    public string CategoryOfWarehouse { get; set; } = null!;

    public string Direct { get; set; } = null!;

    public string RegionCity { get; set; } = null!;
}
