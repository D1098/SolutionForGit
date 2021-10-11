using System;

namespace Lab_16
{
    class Program
    {
        static readonly Random rnd = new();
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите целое число N (N > 0)");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] N = new int[n];
                int num = 1;
                for (int i = 0; i < N.Length; i++)
                {
                    N[i] = num;
                    num += 2;
                    Console.Write(N[i] + " ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\n Введите 3 целых числа (N A D) в одну строку через пробел (N > 1)");
            try
            {
                int[] NAD = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (NAD[0] > 1)
                {
                    double[] N = new double[NAD[0]];
                    for (int i = 0; i < N.Length; i++)
                    {
                        N[i] = NAD[1] * Math.Pow(NAD[2], i);
                        Console.WriteLine(N[i]);
                    }
                }

            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //3
            Console.WriteLine("Задание 3)\n Введите 3 целых числа (N A B) в одну строку через пробел (N > 2)");
            try
            {
                int[] NAB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (NAB[0] > 2)
                {
                    int[] N = new int[NAB[0]];
                    N[0] = NAB[1];
                    N[1] = NAB[2];
                    Console.Write($"{NAB[1]} {NAB[2]} ");
                    for (int i = 2; i < N.Length; i++)
                    {
                        int sum = 0;
                        foreach (var item in N)
                            sum += item;
                        N[i] = sum;
                        // 10 2 3
                        Console.Write(N[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //4
            Console.WriteLine("Задание 4)\n Введите размер массива A (Массив будет заполнен случайно)");
            if (int.TryParse(Console.ReadLine(), out int n2) && n2 > 0)
            {
                int[] N = new int[n2];
                Console.WriteLine("Обычный порядок:");
                for (int i = 0; i < N.Length; i++)
                {
                    N[i] = rnd.Next(0, 10);
                    Console.Write(N[i] + " ");
                }
                Console.WriteLine("\nНужный порядок:");
                if (n2 % 2 == 0)
                    for (int i = 0; i < N.Length / 2; i++)
                        Console.Write(N[i] + " " + N[n2 - i - 1] + " ");
                else
                {
                    for (int i = 0; i < N.Length / 2; i++)
                        Console.Write(N[i] + " " + N[n2 - i - 1] + " ");
                    Console.Write(N[n2 / 2]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)\n Введите размер массива A (Массив будет заполнен случайно)");
            if (int.TryParse(Console.ReadLine(), out int n3) && n3 > 0)
            {
                int[] N = new int[n3];
                Console.WriteLine("Обычный порядок:");
                for (int i = 0; i < N.Length; i++)
                {
                    N[i] = rnd.Next(0, 10);
                    Console.Write(N[i] + " ");
                }
                Console.WriteLine("\nНужный порядок:");
                for (int i = 0; i < N.Length; i++)
                {
                    if (N[i] % 2 == 0)
                        Console.Write(N[i] + " ");
                }
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    if (N[i] % 2 != 0)
                        Console.Write(N[i] + " ");
                }
            }
            else
                Console.WriteLine("Error");
        }
    }
}
