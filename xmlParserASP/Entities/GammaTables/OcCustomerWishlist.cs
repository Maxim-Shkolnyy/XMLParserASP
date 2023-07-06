using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcCustomerWishlist
{
    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public DateTime DateAdded { get; set; }
}
