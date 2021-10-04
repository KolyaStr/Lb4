using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2
{
    class ClassE : ClassB
    {
        public override int Calculation()
        {
            b = c + 1;
            return b;
        }
        public override void Print()
        {
            Console.WriteLine($"b = {b};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }
    }
}
