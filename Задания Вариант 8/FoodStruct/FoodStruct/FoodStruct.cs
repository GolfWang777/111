using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStruct
{
    public struct Food
    {
        public int Weight { get; set; }
        public double Calorie { get; set; }
        public double Value { get; private set; }

        public Food(int weight, double calorie)
        {
            if (weight <= 0 || calorie <= 0)
                throw new Exception("Вес и калорийность должны быть положительными!");
            Weight = weight;
            Calorie = Math.Round(calorie, 1);

            Value = Weight * Calorie / 100;
        }

        public void Read()
        {
            Console.Write("Введите вес продукта в граммах: ");
            Weight = ReadIntNum();
            Console.Write("Введите калорийность (количество килокалорий в 100г продукта): ");
            Calorie = ReadDoubleNum();

            Value = Weight * Calorie / 100;
        }

        public override string ToString()
        {
            return string.Format("{0} г, калорийности {1} Ккал/100г.", Weight, Calorie);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Food))
            {
                return false;
            }

            Food anotherFood = (Food)obj;
            return Weight == anotherFood.Weight && Calorie == anotherFood.Calorie;
        }

        public override int GetHashCode()
        {
            var hashCode = ((Calorie * 18) + Weight) * 18;
            return (int)hashCode;
        }

        public int ReadIntNum()
        {
            var num = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(num, out _) && int.Parse(num) > 0)
                    return int.Parse(num);
                else
                {
                    Console.WriteLine("Введите положительное целое число!");
                    num = Console.ReadLine();
                }
            }
        }

        public double ReadDoubleNum()
        {
            var num = Console.ReadLine();
            while (true)
            {
                if (double.TryParse(num, out _) && double.Parse(num) > 0)
                {
                    return Math.Round(double.Parse(num), 1);
                }
                else
                {
                    Console.WriteLine("Введите положительное целое число!");
                    num = Console.ReadLine();
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Название структуры: {0}. Экземпляр структуры: {1}.", GetType(), ToString());
        }

        public static Food operator +(Food food1, Food food2)
        {
            if (food1.Calorie == food2.Calorie)
                return new Food(food1.Weight + food2.Weight, food1.Calorie);
            else
                throw new Exception("Калорийность у продуктов должна быть одинаковая!");
        }
        public static Food operator -(Food food1, Food food2)
        {
            if (food1.Calorie == food2.Calorie && food1.Weight >= food2.Weight)
                return new Food(food1.Weight - food2.Weight, food1.Calorie);
            else
                throw new Exception("Калорийность у продуктов должна быть одинаковая!");
        }
    }
}
