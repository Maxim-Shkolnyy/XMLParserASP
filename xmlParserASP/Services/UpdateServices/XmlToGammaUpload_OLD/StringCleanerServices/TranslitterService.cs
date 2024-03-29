﻿namespace xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD.StringCleanerServices;

public class TranslitMethods
{
    public class Translitter
    {
        private List<TranslitSymbol> TranslitSymbols { get; set; }

        public string Translit(string source, TranslitType type)
        {
            var result = "";

            for (var i = 0; i < source.Length; i++)
            {
                result = result +
                         (TranslitSymbols.FirstOrDefault(x => x.SymbolRus == source[i].ToString() && x.TranslitType == type) == null
                             ? source[i].ToString()
                             : TranslitSymbols.First(x => x.SymbolRus == source[i].ToString() && x.TranslitType == type).SymbolEng);
            }

            return result;
        }

        // Конструктор - При создании заполняем справочники сопоставлений
        public Translitter()
        {
            TranslitSymbols = new List<TranslitSymbol>();
            var gost = "а:a,б:b,в:v,г:g,д:d,е:e,є:ye,ё:jo,ж:zh,з:z,и:i,і:i,ї:ji,й:jj,к:k,л:l,м:m,н:n,о:o,п:p,р:r,с:s,т:t,у:u,ф:f,х:kh,ц:c,ч:ch,ш:sh,щ:shh,ъ:,ы:y,ь:,э:eh,ю:ju,я:ja, :-,/:-,|:-,?:-,\\:-,.:-,(:-,):-,%:-";
            var iso = "а:a,б:b,в:v,г:g,д:d,е:e,є:ye,ё:yo,ж:zh,з:z,и:i,і:i,ї:yi,й:j,к:k,л:l,м:m,н:n,о:o,п:p,р:r,с:s,т:t,у:u,ф:f,х:h,ц:c,ч:ch,ш:sh,щ:shh,ъ:,ы:y,ь:,э:e,ю:yu,я:ya, :-,/:-,|:-,?:-,\\:-,.:-,(:-,):-,%:-";

            // ГОСТ
            foreach (string item in gost.Split(","))
            {
                string[] symbols = item.Split(":");
                TranslitSymbols.Add(new TranslitSymbol
                {
                    TranslitType = TranslitType.Gost,
                    SymbolRus = symbols[0].ToLower(),
                    SymbolEng = symbols[1].ToLower()
                });
                TranslitSymbols.Add(new TranslitSymbol
                {
                    TranslitType = TranslitType.Gost,
                    SymbolRus = symbols[0].ToUpper(),
                    SymbolEng = symbols[1].ToUpper()
                });
            }

            // ISO
            foreach (string item in iso.Split(","))
            {
                string[] symbols = item.Split(":");
                TranslitSymbols.Add(new TranslitSymbol
                {
                    TranslitType = TranslitType.Iso,
                    SymbolRus = symbols[0].ToLower(),
                    SymbolEng = symbols[1].ToLower()
                });
                TranslitSymbols.Add(new TranslitSymbol
                {
                    TranslitType = TranslitType.Iso,
                    SymbolRus = symbols[0].ToUpper(),
                    SymbolEng = symbols[1].ToUpper()
                });
            }

        }
    }

    public enum TranslitType
    {
        Gost, Iso
    }

    private class TranslitSymbol
    {
        public TranslitType TranslitType { get; set; }
        public string SymbolRus { get; set; }
        public string SymbolEng { get; set; }
    }
}