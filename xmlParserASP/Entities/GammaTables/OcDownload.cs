﻿namespace xmlParserASP.Entities.GammaTables;

public partial class OcDownload
{
    public int DownloadId { get; set; }

    public string Filename { get; set; } = null!;

    public string Mask { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}