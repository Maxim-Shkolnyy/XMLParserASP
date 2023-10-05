using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class OcDownloadDescription
{
    public int DownloadId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;
}
