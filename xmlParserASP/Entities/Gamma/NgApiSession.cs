using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgApiSession
{
    public int ApiSessionId { get; set; }

    public int ApiId { get; set; }

    public string SessionId { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
