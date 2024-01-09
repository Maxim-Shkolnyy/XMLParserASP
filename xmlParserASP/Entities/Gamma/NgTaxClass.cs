using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgTaxClass
{
    public int TaxClassId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
