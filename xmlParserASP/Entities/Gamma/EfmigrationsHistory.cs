﻿using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class EfmigrationsHistory
{
    public string MigrationId { get; set; } = null!;

    public string? ProductVersion { get; set; }
}