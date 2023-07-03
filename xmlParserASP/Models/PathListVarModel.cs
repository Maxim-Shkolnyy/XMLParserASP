namespace xmlParserASP.Models;

public static class PathListVarModel
{

    public static string? Path { get; set; } = @"D:\Telegram Desktop\promua_2405ua.xml"; //work
    //public static string? Path { get; set; } = @"D:\Downloads\Telegram Desktop\promua_2405ru.xml"; //home
    public static List<List<string>>? SheetProducts { get; set; }
    public static string[,]? SheetAtributes { get; set; }
    public static List<string>? UniqXMLAttr { get; set; }

    public static List<string>? UniqXMLCategorys { get; set; }

}