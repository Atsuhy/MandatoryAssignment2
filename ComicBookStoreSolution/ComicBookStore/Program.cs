using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicClassLibrary;

namespace ComicBookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassBook.ToString(new ClassBook("Batman"));
            //var username = Console.ReadLine();
            Console.WriteLine("“Please provide username to access the ComicX system”");
            string username = Console.ReadLine();
            //var password = Console.ReadLine();
            Console.WriteLine("“Please provide password”");
            string password=Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Console.WriteLine();
                Console.WriteLine("Login successful!");
                Console.WriteLine();
                Console.WriteLine("****** Here are your options ******");
                Console.WriteLine("Please select the action.");
                Console.WriteLine("1. Show stock count for each theme of books");
                Console.WriteLine("2. Show total value of each theme type for all comic books in stock");
                Console.WriteLine("3. Register one comic book sold for a given theme");
                Console.WriteLine("4. Get stock status");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Stock count");
                }
                else if (option == "2")
                {
                    Console.WriteLine("Total value");
                }
                else if (option == "3")
                {
                    Console.WriteLine("Register sale");
                }
                else if (option == "4")
                {
                    Console.WriteLine("Stock status");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else
            {
                Console.WriteLine("You are not authorized to access this service");
            }
        }
    }
}
