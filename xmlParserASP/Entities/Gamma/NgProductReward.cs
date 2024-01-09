using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgProductReward
{
    public int ProductRewardId { get; set; }

    public int ProductId { get; set; }

    public int CustomerGroupId { get; set; }

    public int Points { get; set; }
}
