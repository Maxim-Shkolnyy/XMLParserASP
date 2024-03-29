﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgSetting
{
    public int SettingId { get; set; }

    public int StoreId { get; set; }

    public string Code { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public bool Serialized { get; set; }
}
