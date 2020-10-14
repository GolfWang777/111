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
            Console.WriteLine("Введите x центра");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y центра");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x вершины");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y вершины");
            int d = int.Parse(Console.ReadLine());

            int stor = Math.Abs(a - c) * 2;
            int sq = stor * stor;
            int per = stor * 4;



            Console.WriteLine("Площадь: " + sq);
            Console.WriteLine("Периметр: " + per);

            Console.ReadKey();

        }
    }
}

