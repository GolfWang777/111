using System;

namespace zachet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер карты");


            ulong n = new ulong();

            while (true) 
            {
                var inputnumber = (Console.ReadLine());

                if (!ulong.TryParse(inputnumber, out n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                else
                {
                    n = ulong.Parse(inputnumber);
                    Console.WriteLine(calccontrolvalue(inputnumber) == 0);
                    Console.WriteLine(calccontrolvalue(inputnumber));
                    break;
                }
            }

        }



        static int calccontrolvalue(string InputNumber)
        {
            int[] numbersarray = new int[InputNumber.Length];
            for (int i = 0; i < InputNumber.Length; i++)
            {
                numbersarray[i] = int.Parse(Char.ToString(InputNumber[i]));
            }

            int sum = 0;

            if (numbersarray.Length % 2 == 0)
            {
                for (int i = 0; i < numbersarray.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        numbersarray[i] *= 2;
                        if (numbersarray[i] > 9)
                        {
                            numbersarray[i] -= 9;
                        }
                    }
                    sum += numbersarray[i];
                }
            }
            else
            {
                for (int i = 0; i < numbersarray.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        numbersarray[i] *= 2;
                        if (numbersarray[i] > 9)
                        {
                            numbersarray[i] -= 9;
                        }
                    }
                    sum += numbersarray[i];
                }
            }
            return sum % 10;
        }
    }
}