using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._1
{
    class MyClass
    {
        public virtual void  Print(int a, string str, bool temp)
        {
           
            Debug.WriteLine(a);
            Debug.WriteLine(str);
            Debug.WriteLine(temp);
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
