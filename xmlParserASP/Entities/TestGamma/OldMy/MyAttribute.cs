﻿using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities.TestGamma.OldMy;

//[PrimaryKey(nameof(MyAttrId), nameof(LanguageId))]
public class MyAttribute
{
    [Key]

    public int MyAttrId { get; set; }

    [Required]
    public string MyAttrNameRU { get; set; }
    [Required]
    public string MyAttrNameUA { get; set; }

    public string? MyAttrGroup { get; set; }
    public ICollection<SupplierAttribute> SupplierAttributes { get; set; }

}