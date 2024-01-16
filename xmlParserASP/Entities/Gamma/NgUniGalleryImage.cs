namespace xmlParserASP.Entities.Gamma;

public partial class NgUniGalleryImage
{
    public int ImageId { get; set; }

    public int GalleryId { get; set; }

    public string Image { get; set; } = null!;

    public int SortOrder { get; set; }
}
