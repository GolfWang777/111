using System;

namespace _3312
{
    class Program
    {
        static double SinFunction()
        {
            double y;
            y = Math.Sin(4) + 3;
for (int i = 2; i >= 0; i--)
            {
                y = Math.Sin(y) + i;
            }
            return y;
        }
    }
    }

