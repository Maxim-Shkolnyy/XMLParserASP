namespace xmlParserASP.Models
{
    public class PictureViewModel
    {
        public List<(int OrdinalNumber, string Model, string Path, string FileName)> Pictures { get; set; }
        public bool DisplayOrdinalNumber { get; set; }
        public bool DisplayModel { get; set; }
        public bool DisplayPath { get; set; }
        public bool DisplayFileName { get; set; }
    }
}
