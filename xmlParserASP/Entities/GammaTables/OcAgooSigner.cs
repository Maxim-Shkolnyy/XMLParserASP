using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcAgooSigner
{
    public int Id { get; set; }

    public string Pointer { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime Date { get; set; }
}
