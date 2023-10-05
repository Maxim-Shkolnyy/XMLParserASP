using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcUniBannerInCategory
{
    public int BannerId { get; set; }

    public sbyte Type { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Position { get; set; }

    public int Position2 { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public bool Status { get; set; }
}
