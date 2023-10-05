using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcSimpleCart
{
    public int SimpleCartId { get; set; }

    public int? StoreId { get; set; }

    public int? CustomerId { get; set; }

    public string? Email { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Telephone { get; set; }

    public string? Products { get; set; }

    public DateTime DateAdded { get; set; }
}
