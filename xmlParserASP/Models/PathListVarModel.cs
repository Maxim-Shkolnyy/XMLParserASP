namespace xmlParserASP.Models;


public enum Language
{
    Ua,
    Ru,
    En
}
public static class PathListVarModel
{
    public static string? Path { get; set; } = @"D:\Telegram Desktop\promua_2405ru.xml"; //work


    //public static string? Path { get; set; } = @"https://horoz-electric.com.ua/products_feed.xml?hash_tag=143483e1e045e0b718c4c5f63cc41ea5&sales_notes=&product_ids=&label_ids=&exclude_fields=&html_description=0&yandex_cpa=&process_presence_sure=&languages=ru&group_ids=";
    //public static string? Path { get; set; } = @"D:\Downloads\Telegram Desktop\promua_2405ru.xml"; //home

    public static Language Language { get; set; } = Language.Ru;    // Ua  Ru


    public static string XMLProductNode = "item";  // Feron
    //public static string XMLProductNode = "offer";  // Horoz

    // !!!  In ReadAttrXMLTo3Columns set model parsing



    public static List<List<string>>? SheetProducts { get; set; }
    public static string[,]? SheetAtributes { get; set; }
    public static List<string>? UniqXMLAttr { get; set; }
    public static List<string>? UniqXMLCategorys { get; set; }

    
}