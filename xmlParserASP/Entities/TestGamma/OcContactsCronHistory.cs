using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcContactsCronHistory
{
    public int HistoryId { get; set; }

    public int CronId { get; set; }

    public int SendId { get; set; }

    public DateTime DateCronrun { get; set; }

    public DateTime DateCronstop { get; set; }

    public int CountEmails { get; set; }

    public bool CronStatus { get; set; }

    public string TextError { get; set; } = null!;

    public string LogFile { get; set; } = null!;
}
