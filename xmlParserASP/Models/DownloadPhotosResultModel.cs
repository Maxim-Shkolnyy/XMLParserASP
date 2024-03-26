namespace xmlParserASP.Models
{
    public class DownloadPhotosResultModel
    {
        public int? totalPhotosDownloaded { get; set; } = 0;
        public int? totalPhotosResized { get; set; } = 0;
        public int? totalPhotoPassedExists { get; set; } = 0;
        public List<string>? ResultMessages { get; set; } = new();
        public List<KeyValuePair<string, string>>? wrongUrl { get; set; } = new();
        public int? cannotDownload { get; set; } = 0;
        public int? newPhotosAdded { get; set; } = 0;
    }
}
