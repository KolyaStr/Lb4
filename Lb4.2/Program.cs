using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB classB = new ClassB();

            classB.A = 16;
            classB.B = 20;
            classB.C = 42;

            ClassC classC = new ClassC();

            classC.A = 6;
            classC.B = 2;
            classC.C = 9;

            ClassD classD = new ClassD();

            classD.A = 0;
            classD.B = 45;
            classD.C = 31;


            ClassE classE = new ClassE();

            classE.A = 1;
            classE.B = 72;
            classE.C = 9;

            ClassA classA = new ClassA(classC, classE);
            classA.actionA();

            
        }
    }
}
