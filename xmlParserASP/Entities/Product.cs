using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(ProductId), nameof(MyCatId), nameof(SupplierId))]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Select a supplier")]
    [Column("supplier_id")]
    public string? SupplierId { get; set; }

    // Навигационное свойство для связи с Supplier
    public Supplier? Supplier { get; set; }
    public string? ProductNameRU { get; set; }
    public string? ProductNameUA { get; set; }

    public int? MyCatId { get; set; }
    public int? Sku { get; set; }
    public string? Model { get; set; }
    public int? Quantity { get; set; }

    [Range(0, float.MaxValue)]
    public float? Price { get; set; }
    public string? ImageName { get; set; }
    public string? DescriptionRU { get; set; }
    public string? DescriptionUA { get; set; }

    public string? Manufacturer { get; set; }
    public string? DateAdded { get; set; }
    public string? DateModified { get; set; }
    public string? DateAvailable { get; set; }
    public string? SeoKeyword { get; set; }
    public bool? Status { get; set; }
}
