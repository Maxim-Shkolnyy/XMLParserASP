using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlParserASP.Entities
{
    public class SupplierXmlSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierXmlSettingId { get; set; }
        [Required]
        public string SettingName { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

               
        public int? StartGammaIDFrom { get; set; }

        public  string? ProductNode { get; set; }


       
        public string? ModelNode { get; set; }
        public string? ModelXlColumn { get; set; }

        public string? PictureNode { get; set; }
        public string? PictureXlColumn { get; set; }
        public string? imageNameInCatImg { get; set; }

        public string? PhotoFolder { get; set; } = @"D:\Downloads\Photo\";       

        public string? QuantityNode { get; set; }
     
        public string? SupplierNode { get; set; }

        public string? ParamNode { get; set; }

        public string? ParamAttrNode { get; set; }

        public string? Path { get; } = @"D:\Downloads\Telegram Desktop\promua_2405ua.xml"; //home

        //public  string? Path { get; } = @"https://b2b.vestum.ua/data/yml_catalog_rozetka.xml";

        // !!!  In ReadAttrXMLTo3Columns and WriteToXL set model parsing
    }
}
