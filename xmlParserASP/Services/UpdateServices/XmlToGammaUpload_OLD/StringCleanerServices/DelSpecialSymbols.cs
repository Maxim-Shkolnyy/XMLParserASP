using System.Text.RegularExpressions;

namespace xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD.StringCleanerServices;

public static class DelSpecialSymbols
{
    public static string ToLowerAndSpecialSymbolsToDashes(string input)
    {
        input = input.ToLower();
        string regExString = Regex.Replace(input, @"[^\d\w-]", "-"); // .  also will be delete   Ab.jpg  => abjpg

        string result = DelDoubleDashes(regExString);

        return result;
    }



    public static string SpecialSymbolsToDashes(string input)
    {
        string regExString = Regex.Replace(input, @"[^\d\w-]", "-");  // .  also will be delete   Ab.jpg  => abjpg

        string result = DelDoubleDashes(regExString);

        return result;
    }

    private static string DelDoubleDashes(string input)
    {
        if (input.Contains("--"))
        {
            string tryReplace = input.Replace("--", "-");
            DelDoubleDashes(tryReplace);
        }

        if (input.Contains(" "))
        {
            string tryReplace = input.Replace(" ", "-");
            DelDoubleDashes(tryReplace);
        }

        return input;
    }
}
