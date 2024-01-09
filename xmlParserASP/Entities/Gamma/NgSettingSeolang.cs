using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgSettingSeolang
{
    public int SettingId { get; set; }

    public int StoreId { get; set; }

    public string Codekey { get; set; } = null!;

    public string Value { get; set; } = null!;

    public bool Serialized { get; set; }
}
