using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense applicationLicense = new ApplicationLicense();

            Console.WriteLine("Добро пожаловать! ");

            Console.WriteLine("Введите пароль: ");

            string userPassword = Console.ReadLine();

            applicationLicense.Access(userPassword);

        }
    }
}
