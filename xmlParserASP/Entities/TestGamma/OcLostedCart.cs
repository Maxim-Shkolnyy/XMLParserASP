using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcLostedCart
{
    public int LostedId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public int StoreId { get; set; }

    public int LanguageId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public int CustomerId { get; set; }

    public int CustomerGroupId { get; set; }

    public string SessionId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public string Coupon { get; set; } = null!;

    public bool Notified { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateNotified { get; set; }
}
