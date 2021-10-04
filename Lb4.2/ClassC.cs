using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2
{
    class ClassC : ClassB
    {
        public override int Calculation()
        {

            c = a * 8 ;
            return c;
        }
        public override void Print()
        {
            Console.WriteLine($"a = {a};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }
    }
}
