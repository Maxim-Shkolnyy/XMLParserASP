using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcContactsUnsubscribe
{
    public int UnsubscribeId { get; set; }

    public int SendId { get; set; }

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
