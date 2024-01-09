using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomerWishlist
{
    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public DateTime DateAdded { get; set; }
}
