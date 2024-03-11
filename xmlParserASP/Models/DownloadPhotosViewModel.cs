using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Models;

public class DownloadPhotosViewModel
{
    public List<MmSupplierXmlSetting>? SupplierXmlSettings { get; set; }
    public List<NgCategory>? NgCategorys { get; set; }
    public List<NgCategoryDescription>? NgCategoryDescriptions { get; set; }
    public int SelectedSupplierXmlSettingId { get; set; }
    public int? ModelColumn { get; set; }
    public int? PictureColumn { get; set;}
    public int? SheetNumber { get; set; }
    public string? LinkPrefix { get; set; }
    public bool? Rename { get; set; } = false;
}
