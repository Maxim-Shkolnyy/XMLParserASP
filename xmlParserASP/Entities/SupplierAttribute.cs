﻿using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities;

//[PrimaryKey(nameof(SupAttrId), nameof(SupplierId), nameof(LanguageId))]
public class SupplierAttribute
{
    [Key]
    [Required]
    public int SupAttrId { get; set; }
    public int SupplierId { get; set; }
    public string SupAttrNameRU { get; set; }
    public string SupAttrNameUA { get; set; }
    public ICollection<MyAttribute> MyAttributes { get; set; }
}