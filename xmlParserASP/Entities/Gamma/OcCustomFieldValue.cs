using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcCustomFieldValue
{
    public int CustomFieldValueId { get; set; }

    public int CustomFieldId { get; set; }

    public int SortOrder { get; set; }
}
