using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOcfilterSetting
{
    public string Key { get; set; } = null!;

    public byte Serialized { get; set; }

    public string Value { get; set; } = null!;
}
