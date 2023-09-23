using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcOrderCustomField
{
    public int OrderCustomFieldId { get; set; }

    public int OrderId { get; set; }

    public int CustomFieldId { get; set; }

    public int CustomFieldValueId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Location { get; set; } = null!;
}
