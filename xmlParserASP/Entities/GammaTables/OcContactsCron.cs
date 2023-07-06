using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsCron
{
    public int CronId { get; set; }

    public string Name { get; set; } = null!;

    public bool Checking { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateNext { get; set; }

    public int Period { get; set; }

    public int Step { get; set; }

    public int HistoryId { get; set; }

    public int Errors { get; set; }

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }
}
