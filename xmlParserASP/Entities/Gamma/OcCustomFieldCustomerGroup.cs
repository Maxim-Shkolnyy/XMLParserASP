﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcCustomFieldCustomerGroup
{
    public int CustomFieldId { get; set; }

    public int CustomerGroupId { get; set; }

    public bool Required { get; set; }
}