﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.TestGamma;

public partial class OcAttributeTemplateToAttributeToAttributable
{
    public int AttributeTemplateId { get; set; }

    public int AttributeId { get; set; }

    public int AttributableId { get; set; }

    public string AttributableType { get; set; } = null!;

    public int SortOrder { get; set; }
}