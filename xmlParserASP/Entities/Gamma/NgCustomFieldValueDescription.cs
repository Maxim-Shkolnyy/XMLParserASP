using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgCustomFieldValueDescription
{
    public int CustomFieldValueId { get; set; }

    public int LanguageId { get; set; }

    public int CustomFieldId { get; set; }

    public string Name { get; set; } = null!;
}
