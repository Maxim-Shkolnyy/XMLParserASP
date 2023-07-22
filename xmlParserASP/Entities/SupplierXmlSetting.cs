namespace xmlParserASP.Entities
{
    public class SupplierXmlSetting
    {
        public int SupplierId { get; set; }
        ICollection<Supplier?> Supplier { get; set; }

        //public  string? Path { get; } = @"D:\Downloads\promua_2405ru.xml"; //work
        //public  string? Path { get; } = @"https://horoz-electric.com.ua/products_feed.xml?hash_tag=143483e1e045e0b718c4c5f63cc41ea5&sales_notes=&product_ids=&label_ids=&exclude_fields=&html_description=0&yandex_cpa=&process_presence_sure=&languages=ru&group_ids=";
        //public  string? Path { get; } = @"D:\Downloads\Videx.xml"; //Videx
        //public  string? Path { get;} = @"https://b2b.allegro-opt.com.ua/allegro-807a960d080cdbaeea3aec7f5cd8dede.xml"; // Videx, Allegro
        //public  string? Path { get; } = @"https://amperok.com.ua/index.php?route=extension/feed/unixml/violux_full"; // Violux, Amperok 
        //public  string? Path { get; } = @"https://b2b.vestum.ua/data/yml_catalog_rozetka.xml"; // Vestum        
        public string? Path { get; } = @"D:\Downloads\Telegram Desktop\promua_2405ua.xml"; //home
        public int StartGammaIDFrom { get; }

        public  string XMLProductNode { get; } = "item";      // Feron
        //public  string XMLProductNode = "offer";           // Horoz
        public string XMLModelNode { get; } = "model";

        public string XMLPictureNode { get; } = "image";
        public string imageNameInCatImg { get; } = "";

        public string PhotoFolder { get; } = @"D:\Downloads\Photo\";       

        public string XMLQuantityNode { get; } = "quantity";
        //public  string XMLQuantityNode = "stock_quantity";
        public string XMLSupplierNode { get; } = "vendor";

        public string XMLParamNode { get; } = "param";

        public string XMLParamAttrNode { get; }  = "name";

        // !!!  In ReadAttrXMLTo3Columns and WriteToXL set model parsing


        //public  string[,]? CategList { get; set; }
        //public  List<List<string>>? SheetProducts { get; set; }
        //public  string[,]? SheetAtributes { get; set; }
        //public  List<string>? UniqXMLAttr { get; set; }
        //public  List<string>? UniqXMLCategorys { get; set; }
    }
}
