namespace xmlParserASP.Entities.Gamma;

public partial class OcUpload
{
    public int UploadId { get; set; }

    public string Name { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
