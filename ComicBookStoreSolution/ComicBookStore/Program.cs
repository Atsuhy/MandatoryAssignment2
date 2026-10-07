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
            ClassBook book= new ClassBook();
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
                //book.Basic();

               
                while (true)
                {
                    
                    book.Basic();
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        book.StockQuantity();
                    }
                    else if (option == "2")
                    {
                        book.TotalValue();
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("Register sale");
                    }
                    else if (option == "4")
                    {
                        Console.WriteLine("Stock status");
                    }
                    else if (option == "5")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");

                    }
                }
                
               
            }
            else
            {
                Console.WriteLine("You are not authorized to access this service");
            }
            Console.ReadKey();
        }
         
    }
}
