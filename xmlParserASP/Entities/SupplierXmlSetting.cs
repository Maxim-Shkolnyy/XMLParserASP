using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities;

public class SupplierXmlSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierXmlSettingId { get; set; }

    [Required(ErrorMessage = "Enter name")]
    public string SettingName { get; set; }

    // Внешний ключ для связи с Supplier
    [Required(ErrorMessage = "Select a supplier")]
    public int? SupplierId { get; set; }

    // Навигационное свойство для связи с Supplier
    public Supplier? Supplier { get; set; }

    public string? Path { get; set; }
    public int? StartGammaIDFrom { get; set; }
    public string? MainProductNode { get; set; }
    public string? ProductNode { get; set; }
    public string? paramAttribute { get; set; }
    public string? ModelNode { get; set; }
    public string? ModelXlColumn { get; set; }

    public string? PriceNode { get; set; }

    public string? DescriptionNode { get; set; }
    public string? NameNode { get; set; }
    public string? CurrencyNode { get; set; }


    public string? PictureNode { get; set; }
    public string? PicturePriceQuantityXlColumn { get; set; }
    public string? imageNameInCatImg { get; set; }

    public string? PhotoFolder { get; set; } = @"D:\Downloads\Photo\";

    public string? QuantityNode { get; set; }
    public string? QuantityDBStock1 { get; set; }
    public string? QuantityDBStock2 { get; set; }
    public string? QuantityDBStock3 { get; set; }
    public string? QuantityDBStock4 { get; set; }
    public string? QuantityDBStock5 { get; set; }

    public string? QuantityLongTermNode { get; set; }


    public string? SupplierNode { get; set; }

    public string? ParamNode { get; set; }

    public string? ParamAttrNode { get; set; }

   
}

