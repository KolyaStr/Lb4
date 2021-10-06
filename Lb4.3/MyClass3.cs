using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lb4._3
{
    class MyClass3 : MyClass1
    {
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        string strClass3 = "Это класс №3";

        public override void Print()
        {
           
            Debug.WriteLine("**" + strClass3 + "**");
            Debug.WriteLine(y);
        }
    }
}
