using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            
            Debug.WriteLine($"b = {b};");
            Debug.WriteLine($"c = {c};");
        }
    }
}
