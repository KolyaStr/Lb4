namespace Lb4._2
{
    class ClassA
    {

        public ClassB A { get; set; }
        public ClassB B { get; set; }

        public ClassB C { get; set; }
        
        public ClassA(ClassB a, ClassB b)
         {
            A = a;
            B = b;
         }

        public ClassA(ClassB a, ClassB b, ClassB c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void actionA()
        {
            A.Calculation();
            A.Print();
            B.Calculation();
            B.Print();
            if (C != null)
            {
                C.Calculation();
                C.Print();
            }
        }
    }
}
