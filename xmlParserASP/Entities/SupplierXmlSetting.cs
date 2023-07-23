using System.ComponentModel.DataAnnotations;

namespace xmlParserASP.Entities
{
    public class SupplierXmlSetting
    {
        [Key]
        public int SupplierXmlSettingID { get; set; }
        public string SupplierXmlSettingName { get; set; }
        public int SupplierId { get; set; }
        ICollection<Supplier> Supplier { get; set; }        
        public int StartGammaIDFrom { get; set; }

        public  string XMLProductNode { get; set; } = "item";      // Feron
        //public  string XMLProductNode = "offer";           // Horoz
        public string XMLModelNode { get; set; } = "model";

        public string XMLPictureNode { get; set; } = "image";
        public string imageNameInCatImg { get; set; } = "";

        public string PhotoFolder { get; set; } = @"D:\Downloads\Photo\";       

        public string XMLQuantityNode { get; set; } = "quantity";
        //public  string XMLQuantityNode = "stock_quantity";
        public string XMLSupplierNode { get; set; } = "vendor";

        public string XMLParamNode { get; set; } = "param";

        public string XMLParamAttrNode { get; set; } = "name";

        //public  string? Path { get; } = @"D:\Downloads\promua_2405ru.xml"; //work
        //public  string? Path { get; } = @"https://horoz-electric.com.ua/products_feed.xml?hash_tag=143483e1e045e0b718c4c5f63cc41ea5&sales_notes=&product_ids=&label_ids=&exclude_fields=&html_description=0&yandex_cpa=&process_presence_sure=&languages=ru&group_ids=";
        //public  string? Path { get; } = @"D:\Downloads\Videx.xml"; //Videx
        //public  string? Path { get;} = @"https://b2b.allegro-opt.com.ua/allegro-807a960d080cdbaeea3aec7f5cd8dede.xml"; // Videx, Allegro
        //public  string? Path { get; } = @"https://amperok.com.ua/index.php?route=extension/feed/unixml/violux_full"; // Violux, Amperok 
        //public  string? Path { get; } = @"https://b2b.vestum.ua/data/yml_catalog_rozetka.xml"; // Vestum        
        public string? Path { get; } = @"D:\Downloads\Telegram Desktop\promua_2405ua.xml"; //home

        // !!!  In ReadAttrXMLTo3Columns and WriteToXL set model parsing


        //public  string[,]? CategList { get; set; }
        //public  List<List<string>>? SheetProducts { get; set; }
        //public  string[,]? SheetAtributes { get; set; }
        //public  List<string>? UniqueXMLNodes { get; set; }
        //public  List<string>? UniqXMLCategorys { get; set; }
    }
}
