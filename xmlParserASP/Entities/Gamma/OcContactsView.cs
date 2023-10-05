using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcContactsView
{
    public int ViewId { get; set; }

    public int SendId { get; set; }

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
