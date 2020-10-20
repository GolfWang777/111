using System;

namespace ConsoleApp5
{
    class Program
    {
        static double Function(double x)
        {
            double y;
            y = (double)(Math.Abs(x + 1) - Math.Abs(x - 1)) / Math.Abs(x);
            return y;



        }
        static void Main(string[] args)
        {
            double y;
            double x;
            x = double.Parse(Console.ReadLine());
            y = Function(x);
            Console.WriteLine(y);
        }
}
}