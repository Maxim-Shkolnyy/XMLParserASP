namespace xmlParserASP.Entities.GammaTables;

public partial class OcNovaposhtaCity
{
    public int CityId { get; set; }

    public string Ref { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string DescriptionRu { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string SettlementType { get; set; } = null!;

    public string SettlementTypeDescription { get; set; } = null!;

    public string SettlementTypeDescriptionRu { get; set; } = null!;

    public bool Delivery1 { get; set; }

    public bool Delivery2 { get; set; }

    public bool Delivery3 { get; set; }

    public bool Delivery4 { get; set; }

    public bool Delivery5 { get; set; }

    public bool Delivery6 { get; set; }

    public bool Delivery7 { get; set; }

    public string Conglomerates { get; set; } = null!;

    public string PreventEntryNewStreetsUser { get; set; } = null!;

    public bool IsBranch { get; set; }

    public bool SpecialCashCheck { get; set; }
}
