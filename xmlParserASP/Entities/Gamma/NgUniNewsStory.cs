using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgUniNewsStory
{
    public int NewsId { get; set; }

    public string? Image { get; set; }

    public DateTime? DateAdded { get; set; }

    public int Viewed { get; set; }

    public bool Status { get; set; }
}
