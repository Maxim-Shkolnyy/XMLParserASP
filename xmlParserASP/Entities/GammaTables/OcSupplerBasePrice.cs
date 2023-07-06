using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcSupplerBasePrice
{
    public int NomId { get; set; }

    public int? ProductId { get; set; }

    public string? Model { get; set; }

    public decimal? Bprice { get; set; }

    public int? Bpack { get; set; }

    public decimal? Brate { get; set; }

    public string? Bsuppler { get; set; }

    public decimal? Bdisc { get; set; }

    public decimal? Bmin { get; set; }

    public decimal? Bav { get; set; }

    public decimal? Bmax { get; set; }

    public decimal? Optimal { get; set; }

    public decimal? MarketPercentToPrice { get; set; }

    public decimal? MarketPercentToBprice { get; set; }

    public decimal? MarketPercentToBdprice { get; set; }
}
