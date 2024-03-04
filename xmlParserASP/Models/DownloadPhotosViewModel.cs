using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Models;

public class DownloadPhotosViewModel
{
    public List<MmSupplierXmlSetting>? SupplierXmlSettings { get; set; }
    public int SelectedSupplierXmlSettingId { get; set; }
    public int? ModelColumn { get; set; }
    public int? PictureColumn { get; set;}
    public int? SheetNumber { get; set; }
    //public bool? Rename { get; set; } = false;
}
