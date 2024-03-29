﻿namespace xmlParserASP.Entities.Gamma;

public partial class NgBlogCategoryDescription
{
    public int BlogCategoryId { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string MetaDescription { get; set; } = null!;

    public string MetaKeyword { get; set; } = null!;

    public string MetaTitle { get; set; } = null!;

    public string MetaH1 { get; set; } = null!;
}
