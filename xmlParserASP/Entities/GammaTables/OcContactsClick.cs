﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsClick
{
    public int ClickId { get; set; }

    public int SendId { get; set; }

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public string Target { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}