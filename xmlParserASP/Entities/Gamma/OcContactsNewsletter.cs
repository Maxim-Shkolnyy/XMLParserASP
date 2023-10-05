using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcContactsNewsletter
{
    public int NewsletterId { get; set; }

    public int GroupId { get; set; }

    public int CustomerId { get; set; }

    public int UnsubscribeId { get; set; }

    public string Email { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;
}
