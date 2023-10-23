using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace xmlParserASP.Entities.Gamma
{
    public partial class ProductsManualSetQuanity : IEnumerable
    {
        public ProductsManualSetQuanity()
        {
            DateStart = DateOnly.FromDateTime(DateTime.Now);
            DateEnd = DateOnly.FromDateTime(DateTime.Now).AddMonths(1);
        }

        [NotNull] 
        public string Sku { get; set; }
        
        [NotNull] 
        public int SetInStockQty { get; set; }
        public DateOnly? DateStart { get; set; }
        public DateOnly? DateEnd { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}