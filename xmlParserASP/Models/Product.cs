using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Models;

[PrimaryKey(nameof(ProductId), nameof(LanguageId), nameof(MyCatId), nameof(SupplierId))]
public class Product
{
    [Required]
    public int ProductId {get; set;}
    public int SupplierId { get; set; }
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public string? ProductName { get; set; }
    public int MyCatId { get; set; }
    public int? sku { get; set; }
    public int? model { get; set; }
    public int? quantity { get; set; }
    public int? price { get; set; }
    public string? image_name { get; set; }
    public string? description { get; set; }
    public string? manufacturer { get; set; }
    public string? date_added { get; set; }
    public string? date_modified { get; set; }
    public string? date_available { get; set; }
    public string? seo_keyword { get; set;}
    public string? status { get; set; }

}
