namespace xmlParserASP.Entities.Gamma;

public partial class OcRecurring
{
    public int RecurringId { get; set; }

    public decimal Price { get; set; }

    public string Frequency { get; set; } = null!;

    public uint Duration { get; set; }

    public uint Cycle { get; set; }

    public sbyte TrialStatus { get; set; }

    public decimal TrialPrice { get; set; }

    public string TrialFrequency { get; set; } = null!;

    public uint TrialDuration { get; set; }

    public uint TrialCycle { get; set; }

    public sbyte Status { get; set; }

    public int SortOrder { get; set; }
}
