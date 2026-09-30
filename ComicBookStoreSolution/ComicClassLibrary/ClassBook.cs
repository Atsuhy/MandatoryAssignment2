using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComicClassLibrary
{
    public class ClassBook
    {
        public int BatmanStock { get; set; } = 500;
        public int JokerStock { get; set; } = 350;
        public int CatStock { get; set; } = 423;
        public int TheRiddlerStock { get; set; } = 250;
        public int PinguinStock { get; set; } = 612;

        public void StockQuantity() 
        { 
            Console.WriteLine($"Number of Batman novels {BatmanStock} db.");
            Console.WriteLine($"Number of Joker novels {JokerStock} db.");
            Console.WriteLine($"Number of Cat novels {CatStock} db.");
            Console.WriteLine($"Number of TheRiddler novels {TheRiddlerStock} db.");
            Console.WriteLine($"Number of PinguinStock novels {PinguinStock} db.");
        }
    }
}
