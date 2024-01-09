using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgReview
{
    public int ReviewId { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public string Author { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string Plus { get; set; } = null!;

    public string Minus { get; set; } = null!;

    public int VotesPlus { get; set; }

    public int VotesMinus { get; set; }

    public string AdminReply { get; set; } = null!;

    public string Images { get; set; } = null!;

    public bool RealBuyer { get; set; }

    public int Rating { get; set; }

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
