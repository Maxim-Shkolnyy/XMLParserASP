namespace xmlParserASP.Models
{
    public class DownloadPhotosResultModel
    {
        public int? TotalPhotosDownloaded { get; set; } = 0;
        public int? TotalPhotosResized { get; set; } = 0;
        public int? TotalPhotoPassedExists { get; set; } = 0;
        public List<string>? ResultMessages { get; set; } = new();
        public List<KeyValuePair<string, string>>? wrongUrl { get; set; } = new();
        public int? CannotDownload { get; set; } = 0;
        public int? NewPhotosAdded { get; set; } = 0;
    }
}
