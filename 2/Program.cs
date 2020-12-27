using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int c = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                b = numbers[i] + numbers[i + 1];
                if (c < b)
                {
                    c = b;
                }
            }
            Console.WriteLine(c);
            //Your code goes here

        }
    }
}
