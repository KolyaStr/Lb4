using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._4
{
    class ApplicationLicense
    {
        string passwordCommon = "1111";
        string passwordPro = "0000";

        public void AllowTrial()
        {
            Console.WriteLine("Триальный режим");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия ");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платная версия");
        }

        public void Access(string userPassword)
        {
            if (userPassword == passwordCommon)
                AllowCommon();
            else if (userPassword == passwordPro)
                AllowPro();
            else if (string.IsNullOrEmpty(userPassword))
                AllowTrial();
            else
                AllowTrial();
        }
    }
}
