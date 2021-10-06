using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string str = "my string";
            bool temp = true;

            
            MyClass myClass = new MyClass();
            myClass.Print(a, str, temp);

            MyClass inheritance = new Inheritance();
            inheritance.Print(a, str, temp);

        }
    }
}
