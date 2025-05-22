using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("XPS", "Dell", 999);
            notebook1.ShowInfo();
            Console.ReadLine();
        }
    }
}
