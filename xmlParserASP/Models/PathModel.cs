namespace xmlParserASP.Models;

public enum Language
{
    Ua,
    Ru,
    En
}
public static class PathModel
{
    //public static string? Path { get; } = @"D:\Downloads\promua_2405ru.xml"; //work
    //public static string? Path { get; } = @"D:\Downloads\All.xlsx"; //work
    //public static string? Path { get; } = @"https://horoz-electric.com.ua/products_feed.xml?hash_tag=143483e1e045e0b718c4c5f63cc41ea5&sales_notes=&product_ids=&label_ids=&exclude_fields=&html_description=0&yandex_cpa=&process_presence_sure=&languages=ru&group_ids=";
    //public static string? Path { get; } = @"D:\Downloads\Telegram Desktop\promua_2405ua.xml"; //home
    public static string? Path { get; } = @"https://gamma.net.ua/All_xml"; //Gamma All 10.08.23


    //public static string? Path { get; } = @"D:\Downloads\Videx.xml"; //Videx
    //public static string? Path { get;} = @"https://b2b.allegro-opt.com.ua/allegro-807a960d080cdbaeea3aec7f5cd8dede.xml"; // Videx, Allegro

    //public static string? Path { get; } = @"https://amperok.com.ua/index.php?route=extension/feed/unixml/violux_full"; // Violux, Amperok 
    //public static string? Path { get; } = @"https://b2b.vestum.ua/data/yml_catalog_rozetka.xml"; // Vestum
    //public static string? Path { get; } = @"D:\Downloads\Novodvor.xlsx";



    public static Language Language { get; } = Language.Ua;    // Ua  Ru

    public const int StartGammaIDFrom = 2255;


    //public static string ProductNode = "item";      // Feron
    public static string ProductNode = "offer";  // Horoz

    public static string ModelNode = "code";
    public static string ModelXlColumn = "Артикул";

    public static int XlSheetNumber = 1;



    public static string PictureNode = "picture";
    public static string PictureXlColumn = "URL";

    public static string imageNameInCatImg = "";
    

    public static string PhotoFolder = @"D:\Downloads\Photo\";
    public static string Supplier = "Novodvorsky";


    // public static string QuantityNode = "quantity";
    public static string QuantityNode = "stock_quantity";

    public static string SupplierNode = "vendor";



    public static string ParamNode = "param";

    public static string ParamAttrNode = "name";

    // !!!  In ReadAttrXMLTo3Columns and WriteToXL set model parsing


    public static string[,]? CategList { get; set; }
    public static List<List<string>>? SheetProducts { get; set; }
    public static string[,]? SheetAtributes { get; set; }
    public static List<string>? UniqueXMLNodes { get; set; }
    public static List<string>? UniqXMLCategorys { get; set; }

    
}