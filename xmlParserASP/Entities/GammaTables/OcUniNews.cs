﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcUniNews
{
    public int NewsId { get; set; }

    public string? Image { get; set; }

    public DateTime DateAdded { get; set; }

    public int Viewed { get; set; }

    public bool Status { get; set; }
}