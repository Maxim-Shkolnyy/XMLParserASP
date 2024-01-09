using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgOmproAdminSetting
{
    public bool LogSql { get; set; }

    public int Groupdefault { get; set; }

    public string TargetMailTemplate { get; set; } = null!;

    public string TargetSmsTemplate { get; set; } = null!;

    public string TargetTlgrmTemplate { get; set; } = null!;

    public string TlgrmBotToken { get; set; } = null!;

    public string TlgrmAdminIdes { get; set; } = null!;
}
