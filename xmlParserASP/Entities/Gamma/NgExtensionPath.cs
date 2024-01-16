namespace xmlParserASP.Entities.Gamma;

public partial class NgExtensionPath
{
    public int ExtensionPathId { get; set; }

    public int ExtensionInstallId { get; set; }

    public string Path { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
