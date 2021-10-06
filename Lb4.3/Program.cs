using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();
            myClass1.X = 5;
            myClass1.Print();

            MyClass2 myClass2 = new MyClass2();
            Debug.WriteLine("Введите информацию для класса 2:");
            myClass2.Str = "Строка";
            myClass2.Print();

            MyClass3 myClass3 = new MyClass3();
            myClass3.Y = 544;
            myClass3.Print();

            MyClass4 myClass4 = new MyClass4();
            myClass4.Z = 913;
            myClass4.Print();
        }
    }
}
