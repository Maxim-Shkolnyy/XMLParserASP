namespace xmlParserASP.Entities.Gamma;

public partial class NgModification
{
    public int ModificationId { get; set; }

    public int ExtensionInstallId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Xml { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DateAdded { get; set; }
}
