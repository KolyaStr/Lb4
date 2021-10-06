using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._2
{
    class ClassD : ClassB
    {
        public override int Calculation()
        {

            a = (a * 9 + 12) - b * c;
            return a;
        }
        public override void Print()
        {
            
            Debug.WriteLine($"a = {a};");
        }
    }
}
