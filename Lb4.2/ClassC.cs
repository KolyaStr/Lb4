using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            
            Debug.WriteLine($"a = {a};");
            Debug.WriteLine($"c = {c};");
        }
    }
}
