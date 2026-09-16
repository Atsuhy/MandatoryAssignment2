using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComicClassLibrary
{
    public class ClassBook
    {
        public string Title { get; set; }
        
        public ClassBook(string title)
        {
            Title = title;
            
        }
        public static string ToString(ClassBook title)
        {
            return $"{title.Title}";
        }
    }
}
