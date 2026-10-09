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

        public void Basic()
        {
            Console.WriteLine();
            Console.WriteLine("****** Here are your options ******");
            Console.WriteLine("Please select the action.");
            Console.WriteLine("1. Show stock count for each theme of books");
            Console.WriteLine("2. Show total value of each theme type for all comic books in stock");
            Console.WriteLine("3. Register one comic book sold for a given theme");
            Console.WriteLine("4. Get stock status");
            Console.WriteLine("5. Quit");
        }
        public void StockQuantity() 
        { 
            Console.WriteLine($"Number of Batman novels {BatmanStock} db.");
            Console.WriteLine($"Number of Joker novels {JokerStock} db.");
            Console.WriteLine($"Number of Cat novels {CatStock} db.");
            Console.WriteLine($"Number of TheRiddler novels {TheRiddlerStock} db.");
            Console.WriteLine($"Number of PinguinStock novels {PinguinStock} db.");
        }
        public void TotalValue()
        {
            Console.WriteLine($"Total value of Batman novels {22} USD.");
            Console.WriteLine($"Total value of Joker novels {13} USD.");
            Console.WriteLine($"Total value of Cat novels {11} USD.");
            Console.WriteLine($"Total value of TheRiddler novels {15} USD.");
            Console.WriteLine($"Total value of PinguinStock novels {19} USD.");
        }
        public void RegisterSale()
        {
            
        }
        public void Sum()
        {
            int sum = BatmanStock + JokerStock + CatStock + TheRiddlerStock + PinguinStock;
            Console.WriteLine(sum);
        }
        public void GetStatus(int number)
        {
            if (number <= 1000)
            {
                Console.WriteLine("VeryLow");
            }
            else if (number <= 1500)
            {
                Console.WriteLine("Low");
            }
            else if (number < 5000)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Over");
            }
            return;
        }
    }
}
