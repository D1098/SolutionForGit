using System;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите целое положительное число A");
            if (uint.TryParse(Console.ReadLine(), out uint a) && a > 0)
            {
                Console.WriteLine(" Введите целое положительное число B");
                if (uint.TryParse(Console.ReadLine(), out uint b) && b > 0)
                    for (uint i = a; i <= b; i++)
                        for (int j = 0; j < i; j++)
                            Console.WriteLine(i);
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\n Введите положительное число A");
            if (float.TryParse(Console.ReadLine(), out float a2) && a2 > 0)
            {
                Console.WriteLine(" Введите положительное число B (A > B)");
                if (float.TryParse(Console.ReadLine(), out float b) && b > 0 && b < a2)
                    Console.WriteLine("Длина незанятой части:" + Math.Round(a2 % b, 4));
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)\n Введите положительное число N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                int sum = 0;
                for (int i = 1; sum < n; i++)
                {
                    sum += i;
                    if (sum >= n)
                        Console.WriteLine($"K = {i}, Sum = {sum}");
                }
            }
            else
                Console.WriteLine("Error");
            //4
            Console.WriteLine("Задание 4)\n Введите число процентов (0 < P(вещ.) < 25)");
            if (float.TryParse(Console.ReadLine(), out float P) && P > 0 && P < 25)
            {
                double deposit = 1000;
                for (int i = 1; deposit <= 1100; i++)
                {
                    deposit *= (1 + P / 100);
                    if (deposit > 1100)
                        Console.WriteLine($"Месяцев: {i}, S = {deposit}");
                }
            }
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)\n Введите целое положительное число A");
            if (uint.TryParse(Console.ReadLine(), out uint a3) && a3 > 0)
            {
                Console.WriteLine(" Введите целое положительное число B");
                if (uint.TryParse(Console.ReadLine(), out uint b3) && b3 > 0)
                {
                    while (a3 != 0 && b3 != 0)
                    {
                        if (a3 > b3)
                            a3 = a3 % b3;
                        else
                            b3 = b3 % a3;
                    }
                    // одно из них равно 0
                    Console.WriteLine(a3 + b3);
                }
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //6
            Console.WriteLine("Задание 6)\n Введите положительное число N (N > 1)");
            if (long.TryParse(Console.ReadLine(), out long n2) && n2 > 1)
            {
                long f = 0, f2 = 1, f3 = 1;
                int count = 2;
                // Проверка принадлежности к числам Фибоначчи
                if (Math.Sqrt(5.0 * Math.Pow(n2, 2) - 4) % 1 == 0 || Math.Sqrt(5.0 * Math.Pow(n2, 2) + 4) % 1 == 0)
                {
                    while (f != n2)
                    {
                        f = f2 + f3;
                        f3 = f2;
                        f2 = f;
                        count++;
                    }
                    Console.WriteLine("K = " + count);
                }
                else
                    Console.WriteLine("Это не число Фибоначчи");
            }
            else
                Console.WriteLine("Error");
        }
    }
}
