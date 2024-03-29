﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgReturnHistory
{
    public int ReturnHistoryId { get; set; }

    public int ReturnId { get; set; }

    public int ReturnStatusId { get; set; }

    public bool Notify { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
