using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2
{
    class ClassB
    {
        protected int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        protected int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        protected int c;

        public int C
        {
            get { return c; }
            set { c = value; }
        }


        public virtual int Calculation()
        {

            c = (a * 8 + 12)-b;
            return c;
        }
        public virtual void Print()
        {
            Console.WriteLine($"a = {a};");
            Console.WriteLine($"b = {b};");
            Console.WriteLine($"c = {c};");
            Console.WriteLine();
        }
        
    }
}
