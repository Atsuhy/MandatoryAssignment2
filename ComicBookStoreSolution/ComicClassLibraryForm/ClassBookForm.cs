using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicClassLibraryForm
{
    public class ClassBookForm
    {
        public int BatmanStock { get; set; } = 500;
        public int JokerStock { get; set; } = 350;
        public int CatStock { get; set; } = 423;
        public int TheRiddlerStock { get; set; } = 250;
        public int PinguinStock { get; set; } = 612;

        public const int BatmanPrice = 22;
        public const int JokerPrice = 13;
        public const int CatPrice = 11;
        public const int TheRiddlerPrice = 15;
        public const int PinguinPrice = 19;

        public int BatmanSold { get; set; } = 0;
        public int JokerSold { get; set; } = 0;
        public int CatSold { get; set; } = 0;
        public int TheRiddlerSold { get; set; } = 0;
        public int PinguinSold { get; set; } = 0;

        // 1-gyel csökkenti az adott téma készletét.
        // true, ha sikerült; false, ha elfogyott vagy ismeretlen a téma.
        public bool OneBookSold(string themeType)
        {
            if (themeType == "Batman" && BatmanStock > 0) { BatmanStock--; BatmanSold++; }
            else if (themeType == "Joker" && JokerStock > 0) { JokerStock--; JokerSold++; }
            else if (themeType == "Cat" && CatStock > 0) { CatStock--; CatSold++; }
            else if (themeType == "TheRiddler" && TheRiddlerStock > 0) { TheRiddlerStock--; TheRiddlerSold++; }
            else if (themeType == "Pinguin" && PinguinStock > 0) { PinguinStock--; PinguinSold++; }
            else return false;

            return true;
        }
        public int TotalRevenue()
        {
            return BatmanSold * BatmanPrice
                 + JokerSold * JokerPrice
                 + CatSold * CatPrice
                 + TheRiddlerSold * TheRiddlerPrice
                 + PinguinSold * PinguinPrice;
        }

        public int TotalStock()
        {
            return BatmanStock + JokerStock + CatStock + TheRiddlerStock + PinguinStock;
        }

        // VeryLow / Low / Normal / Over
        public string GetStockStatus()
        {
            int total = TotalStock();

            if (total < 1000) return "VeryLow";
            if (total <= 1500) return "Low";
            if (total <= 5000) return "Normal";
            return "Over";
        }
    }
}
