using xmlParserASP.Entities;

namespace xmlParserASP.Models;

public class DownloadPhotosViewModel
{
    public List<SupplierXmlSetting>? SupplierXmlSettings { get; set; }
    public int SelectedSupplierXmlSettingId { get; set; }
    public int? ModelColumn { get; set; }
    public int? PictureColumn { get; set;}

    public int? SheetNumber { get; set; }
}
