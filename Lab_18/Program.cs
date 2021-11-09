using System;

namespace Lab_18
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите размер массивов N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
                try
                {
                    int[] A = new int[n], B = new int[n], C = new int[n];
                    for (int i = 0; i < A.Length; i++)
                    {
                        A[i] = rnd.Next(0, 10);
                        B[i] = rnd.Next(0, 10);
                    }
                    Console.WriteLine("Изначально");
                    foreach (var item in A)
                        Console.Write(item + " ");
                    Console.WriteLine();
                    foreach (var item in B)
                        Console.Write(item + " ");
                    Console.WriteLine();
                    C = A;
                    A = B;
                    B = C;
                    Console.WriteLine("Поменяли");
                    foreach (var item in A)
                        Console.Write(item + " ");
                    Console.WriteLine();
                    foreach (var item in B)
                        Console.Write(item + " ");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //2
            Console.WriteLine("\nЗадание 2)\n Введите размер массива N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n2) && n2 > 1)
                try
                {
                    int[] A = new int[n2];
                    double[] B = new double[n2];
                    Console.WriteLine($"Введите {n2} целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    B[0] = A[0];
                    for (int i = 0; i < A.Length; i++)
                    {
                        double sum = 0;
                        for (int j = 0; j <= i; j++)
                        {
                            sum += A[j];
                        }
                        sum /= i + 1;
                        B[i] = Math.Round(sum, 1);
                    }
                    foreach (var item in B)
                        Console.Write(item + " ");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //3
            Console.WriteLine("\nЗадание 3)\n Введите размер массива N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n3) && n3 > 1)
                try
                {
                    int[] A = new int[n3];
                    Console.WriteLine($"Введите {n3} целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int num = 0;
                    foreach (var item in A)
                    {
                        if (item % 2 != 0)
                            num = item;
                    }
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] % 2 != 0)
                            A[i] += num;
                    }
                    foreach (var item in A)
                        Console.Write(item + " ");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //4
            Console.WriteLine("\nЗадание 4)\n Введите размер массива N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n4) && n4 > 1)
                try
                {
                    int[] A = new int[n4];
                    Console.WriteLine($"Введите {n4} целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int max = int.MinValue, min = int.MaxValue, maxNum = -1, minNum = -1;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] > max)
                        {
                            max = A[i];
                            maxNum = i;
                        }
                        if (A[i] < min)
                        {
                            min = A[i];
                            minNum = i;
                        }
                    }
                    if (maxNum != -1 && minNum != -1)
                        for (int i = 0; i < A.Length; i++)
                        {
                            A[i] = maxNum > minNum ? i > minNum && i < maxNum ? 0 : A[i] : i > maxNum && i < minNum ? 0 : A[i];
                        }
                    foreach (var item in A)
                        Console.Write(item + " ");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //5
            Console.WriteLine("\nЗадание 5)\n Введите размер массива N (N > 1)");
            if (int.TryParse(Console.ReadLine(), out int n5) && n5 > 1)
                try
                {
                    int[] A = new int[n5];
                    Console.WriteLine($"Введите {n5} целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    //for (int i = A.Length - 1; i > 0; i--)
                    //{
                    //    if (A[i] < A[0])
                    //    {
                    //        for (int j = A.Length - 1; j > i; j--)
                    //        {
                    //            Console.WriteLine(i);
                    //            Console.WriteLine(A[j+1]);
                    //            A[j + 1] = A[j];
                    //        }
                    //        A[i + 1] = A[0];
                    //    }
                    //}
                    Array.Resize(ref A, A.Length + 1);
                    for (int i = A.Length - 2; i >= 0; i--)
                    {
                        Console.WriteLine("A[i]= " + A[i]);
                        if (A[i] < A[0])
                        {
                            for (int j = A.Length - 2; j >= i; j--)
                            {
                                Console.WriteLine(j);
                                A[j + 1] = A[j];
                            }
                            A[i + 1] = A[0];
                            break;
                        }
                    }
                    for (int i = 1; i < A.Length; i++)
                    {
                        Console.Write(A[i] + " ");
                    }
                }
                catch (Exception e) { Console.WriteLine("Ошибка " + e.Message); }
        }
    }
}