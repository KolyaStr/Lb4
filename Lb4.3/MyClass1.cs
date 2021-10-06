using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            
            Debug.WriteLine("Класс №1");
            Debug.WriteLine(str1);
            Debug.WriteLine(str2);
            Debug.WriteLine(x);
        }
    }
}
