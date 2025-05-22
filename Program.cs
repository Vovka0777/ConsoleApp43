using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyStruct myStruct = new MyStruct();
            void ClassTaker(MyClass myClass)
            {
                myClass.change = "Изменено";
                Console.WriteLine(myClass.change);
            }
            void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "Изменено";
                Console.WriteLine(myStruct.change);
            }
            ClassTaker(new MyClass());
            StruktTaker(new MyStruct());
            MyStruct str;
            MyClass clss = new MyClass();
            str.change = "Не изменено";
            Console.WriteLine(str.change);
            clss.change = "Не изменено";
            Console.WriteLine(clss.change);
            
            Console.Read();
        }
    }
}
