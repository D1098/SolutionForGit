using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите цену кг конфет");
            if (double.TryParse(Console.ReadLine(), out double price) && price > 0)
            {
                Console.WriteLine($"0.1: {0.1 * price}\n0.2: {0.2 * price}\n" +
                                  $"0.3: {0.3 * price}\n0.4: {0.4 * price}\n" +
                                  $"0.5: {0.5 * price}\n0.6: {0.6 * price}\n" +
                                  $"0.7: {0.7 * price}\n0.8: {0.8 * price}\n" +
                                  $"0.9: {0.9 * price}\n  1: {  1 * price}\n");
            }
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\n Введите целое число (>0)");
            if (uint.TryParse(Console.ReadLine(), out uint num) && num > 0)
            {
                double product = 1;
                for (int i = 1; i <= num; i++)
                    product *= (1 + 0.1 * i);
                Console.WriteLine("Произведение: " + product);
            }
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)\n Введите целое число (>0)");
            if (uint.TryParse(Console.ReadLine(), out uint num2) && num2 > 0)
            {
                double square = 0;
                for (int i = 1; i <= 2 * num2 - 1; i += 2)
                {
                    square += i;
                    Console.WriteLine(" " + square);
                }
                Console.WriteLine("N^2: " + square);
            }
            else
                Console.WriteLine("Error");
            //4
            Console.WriteLine("Задание 4)\n Введите целое число (>0)");
            if (uint.TryParse(Console.ReadLine(), out uint num3) && num3 > 0)
            {
                Console.WriteLine(" Введите вещ. число A");
                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    double sum = 0;
                    for (int i = 0; i <= num3; i++)
                    {
                        sum += Math.Pow(a, i);
                    }
                    Console.WriteLine($"Сумма: {sum}");
                }
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)\n Введите целое число (>0)");
            if (uint.TryParse(Console.ReadLine(), out uint num4) && num4 > 0)
            {
                Console.WriteLine(" Введите вещ. число A");
                if (double.TryParse(Console.ReadLine(), out double a))
                {
                    double sum = 0;
                    for (int i = 0; i <= num4; i++)
                    {
                        sum += Math.Pow(-1, i) * Math.Pow(a, i);
                    }
                    Console.WriteLine($"Сумма: {sum}");
                }
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
