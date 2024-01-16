namespace xmlParserASP.Entities.Gamma;

public partial class NgOmproTplProduct
{
    public int TemplateId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Template { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DateModified { get; set; }
}
