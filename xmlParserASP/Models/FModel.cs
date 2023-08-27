namespace xmlParserASP.Models
{
    public static class FModel
    {
        public static string dDownloadsTelegramPath = @"D:\Telegram Desktop\";                   //Work desktop
                                                                                                 //public static string dDownloadsTelegramPath = @"D:\Downloads\Telegram Desktop\";      //Home desctop 

        //  OPENCART

        public static int codeOpencartColumn = 7;
        public static int categoryOpencartColumn = 6;
        public static int quantityOpencartColumn = 14;
        public static int categoryVyvisky = 60;
        public static int categoryDerevBalka = 63;
        public static string opencartVygruzkaFilenaneStartsWith = @"p_gamma.net.ua";

        //  PROM

        //public static int codeOpencartColumn = 1;
        //public static int categoryOpencartColumn = 18;
        //public static int quantityOpencartColumn = 17;
        //public static int categoryVyvisky = 101558897;
        //public static int categoryDerevBalka = 108419735;
        //public static readonly string opencartVygruzkaFilenaneStartsWith = @"export-products";

        public static int flaCodeColumn = 1;
        public static int flaQuantityColumn = 36;

        public static string dDownloadsPath = @"D:\Downloads\";
        public static string prom = "export-products";

        public static string nalichuyeFile = "Наличие для сайтов";
        public static string password = "123321";
        public static FileInfo? vygruzkaNalichiyeAllFileInfo;
        public static FileInfo? vygruzkaOpencartFileInfo;
        //public static FileInfo? vygruzkaPromFileInfo;
        public static string? opecartPath;
        public static string? promPath;
        public static string? FLa888Path = @"D:\Downloads\Excel\Ф-ла 888_NEW12 .xlsx";
    }
}
