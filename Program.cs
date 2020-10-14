using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int number = int.Parse(Console.ReadLine());

            int a = number % 10;
            int b = (number % 100 - number % 10) / 10;
            int c = (number % 1000 - number % 100) / 100;
            int d = number / 1000;


            Console.WriteLine("Число единиц: " + a);
            Console.WriteLine("Число тысяч: " + d);
            Console.Write("произведение цифр" + d * b * c * a);

            Console.ReadKey();

        }
    }
}