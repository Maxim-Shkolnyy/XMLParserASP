namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsCronDatum
{
    public int CronDataId { get; set; }

    public int CronId { get; set; }

    public int StoreId { get; set; }

    public string SendTo { get; set; } = null!;

    public string SendToData { get; set; } = null!;

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public bool SendRegion { get; set; }

    public int SendCountryId { get; set; }

    public int SendZoneId { get; set; }

    public bool InversRegion { get; set; }

    public bool InversProduct { get; set; }

    public bool InversCategory { get; set; }

    public bool InversCustomer { get; set; }

    public bool InversClient { get; set; }

    public bool InversAffiliate { get; set; }

    public bool SendProducts { get; set; }

    public int LangProducts { get; set; }

    public int LanguageId { get; set; }

    public bool Reqreview { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Attachments { get; set; } = null!;

    public string AttachmentsCat { get; set; } = null!;

    public string Dopurl { get; set; } = null!;

    public string Static { get; set; } = null!;

    public int EmailTotal { get; set; }

    public bool UnsubUrl { get; set; }

    public bool ControlUnsub { get; set; }

    public int LimitStart { get; set; }

    public int LimitEnd { get; set; }

    public bool EmnovalidAction { get; set; }

    public bool EmbadAction { get; set; }

    public bool EmsuspectAction { get; set; }

    public DateTime DateAdded { get; set; }
}
