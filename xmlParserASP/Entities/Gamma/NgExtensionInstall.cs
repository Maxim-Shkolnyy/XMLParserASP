namespace xmlParserASP.Entities.Gamma;

public partial class NgExtensionInstall
{
    public int ExtensionInstallId { get; set; }

    public int ExtensionDownloadId { get; set; }

    public string Filename { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
