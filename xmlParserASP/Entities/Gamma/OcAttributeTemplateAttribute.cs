﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcAttributeTemplateAttribute
{
    public int TemplateId { get; set; }

    public int AttributeId { get; set; }

    public int LanguageId { get; set; }

    public string Text { get; set; } = null!;
}