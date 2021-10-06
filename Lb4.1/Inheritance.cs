using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._1
{
    class Inheritance : MyClass
    {
        public override void Print(int a, string str, bool temp)
        {
            Debug.WriteLine($"Тип данных аргумента a: {a.GetType()}");

            Debug.WriteLine($"Тип данных аргумента str: {str.GetType()}");

            Debug.WriteLine($"Тип данных аргумента temp: {temp.GetType()}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Тип данных аргумента a: {a.GetType()}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Тип данных аргумента str: {str.GetType()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Тип данных аргумента temp: {temp.GetType()}");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
