using xmlParserASP.Entities;

namespace xmlParserASP.Models
{
    public class DownloadPhotosViewModel
    {
        public List<SupplierXmlSetting> SupplierXmlSettings { get; set; }
        public int SelectedSupplierXmlSettingId { get; set; }
    }
}
