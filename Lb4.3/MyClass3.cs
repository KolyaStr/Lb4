using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._3
{
    class MyClass3 : MyClass1
    {
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        string strClass3 = "Это класс №3";

        public override void Print()
        {
            Console.WriteLine("**" + strClass3 + "**");
            Console.WriteLine(y);
            Console.WriteLine();
        }
    }
}
