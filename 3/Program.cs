using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int tmp = 1;
            int alf;
            alf = Convert.ToInt16(Console.ReadLine());
            while (tmp != 0)
            {
                tmp = Convert.ToInt16(Console.ReadLine());
                if (tmp > alf)
                {
                    sum += tmp;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
