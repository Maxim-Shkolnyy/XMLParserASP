﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities.TestGamma.OldMy;

public class Supplier
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Supplier name must be between 3 and 50 characters.")]
    public string SupplierName { get; set; }

    public ICollection<Product>? Products { get; set; }
    public ICollection<SupplierXmlSetting>? SupplierXmlSetting { get; set; }

}