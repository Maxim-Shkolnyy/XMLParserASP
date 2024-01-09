using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomField
{
    public int CustomFieldId { get; set; }

    public string Type { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Validation { get; set; } = null!;

    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public int SortOrder { get; set; }
}
