using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace xmlParserASP.Entities.Gamma
{
    public partial class ProductsManualSetQuanity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sku { get; set; }

        public int SetInStockQty { get; set; }
        public DateOnly? DateStart { get; set; } = null;
        public DateOnly? DateEnd { get; set; } = null;
    }
}
