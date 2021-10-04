using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._3
{
    class MyClass2 : MyClass1
    {
        private string str;

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        string strClass2 = "Это класс №2";
        
        public override void Print()
        {
            Console.WriteLine(strClass2 + "!");
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
