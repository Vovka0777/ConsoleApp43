using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookes = new Book("Война и мир", "Толстой", 1869, 1225);
            bookes.Books.Add(new Book("Война и мир", "Толстой", 1869, 1225));
            bookes.Books.Add(new Book("Колобок", "Братья гримм", 1999, 8));
            bookes.ShowBook();
            Console.Read();
        }
    }
}
