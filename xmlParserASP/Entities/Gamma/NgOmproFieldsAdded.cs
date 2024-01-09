using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOmproFieldsAdded
{
    public int Id { get; set; }

    public string Table { get; set; } = null!;

    public string Field { get; set; } = null!;
}
