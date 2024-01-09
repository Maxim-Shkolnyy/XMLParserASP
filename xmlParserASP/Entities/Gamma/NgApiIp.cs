using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgApiIp
{
    public int ApiIpId { get; set; }

    public int ApiId { get; set; }

    public string Ip { get; set; } = null!;
}
