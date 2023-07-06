using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.GammaTables;

public partial class OcContactsTemplate
{
    public int TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;
}
