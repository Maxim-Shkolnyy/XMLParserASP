namespace xmlParserASP.Entities.Gamma;

public partial class NgDownload
{
    public int DownloadId { get; set; }

    public string Filename { get; set; } = null!;

    public string Mask { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
