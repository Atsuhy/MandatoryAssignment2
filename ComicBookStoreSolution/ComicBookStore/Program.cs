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
            
            if(username == "admin")
            {
                
            }
            Console.ReadKey();
        }
    }
}
