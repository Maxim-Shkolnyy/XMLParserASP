﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace xmlParserASP.Entities.Gamma;

public partial class Mm_ManualSetPrice
{
    //public ProductsManualSetQuanity()
    //{
    //    DateStart = DateOnly.FromDateTime(DateTime.Now);
    //    DateEnd = DateOnly.FromDateTime(DateTime.Now).AddMonths(1);
    //}
    [Key]
    public int Id { get; set; }
    [NotNull]
    public string Sku { get; set; }
    [NotNull] 
    public int SetInStockPrice { get; set; }
    public DateTime? DateStart { get; set; } = DateTime.Now;
    public DateTime? DateEnd { get; set; } = DateTime.Now.AddMonths(1);
}