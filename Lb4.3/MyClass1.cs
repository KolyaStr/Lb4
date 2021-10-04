using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._3
{
    class MyClass1
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        string str1 = "hello";
        string str2 = "world";

        public virtual void Print()
        {
            Console.WriteLine("Класс №1");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(x);
            Console.WriteLine();
        }
    }
}
