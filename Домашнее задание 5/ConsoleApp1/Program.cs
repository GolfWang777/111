using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var suitcase = "пирамида";
                var dima = suitcase.Substring(6, 1) + suitcase.Substring(5, 1) + suitcase.Substring(4, 1) + suitcase.Substring(3, 1);
                string iraida = suitcase.Substring(1, 3) + suitcase.Substring(5, 3);
                Console.WriteLine($"Вот что получилось: {dima}, {iraida}.");
                Console.ReadKey();
            }
        }
    }
