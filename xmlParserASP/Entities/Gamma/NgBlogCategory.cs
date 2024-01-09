using System;
using System.Collections.Generic;

namespace xmlParserASP.Entities.Gamma;

public partial class NgBlogCategory
{
    public int BlogCategoryId { get; set; }

    public string? Image { get; set; }

    public int ParentId { get; set; }

    public bool Top { get; set; }

    public int Column { get; set; }

    public int SortOrder { get; set; }

    public bool Status { get; set; }

    public bool? Noindex { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
