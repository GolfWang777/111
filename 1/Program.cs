using System;

namespace _1
{
    class Program
    {
        public class Program
        {
            public static void Main(string[] args)
            {

                double x = 0;
                double pi = 3.14159265358979323846264;
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 2 * pi;)
                {

                    x = Math.Sin(i);
                    Console.WriteLine(x);
                    i = i + (pi / n);
                }

            }
        }

