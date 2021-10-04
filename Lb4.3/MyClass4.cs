using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._3
{
    class MyClass4 : MyClass1
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        string strClass4 = "Это класс №4";

        public override void Print()
        {
            Console.WriteLine($"|| {strClass4} ||");
            Console.WriteLine(z);
            Console.WriteLine();
        }
    }
}
