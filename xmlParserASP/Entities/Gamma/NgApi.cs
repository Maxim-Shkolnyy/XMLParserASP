using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgApi
{
    public int ApiId { get; set; }

    public string Username { get; set; } = null!;

    public string Key { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
