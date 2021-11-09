using System;
using System.Linq;
namespace Lab_17
{
    class Program
    {
        static string Task5(int[] A)
        {
            string sOut = "Ошибка";
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                    if (A[i] == A[j] && i != j)
                    {
                        sOut = $"A[{i}] = {A[i]} equals A[{j}] = {A[j]}";
                        return sOut;
                    }
            }
            return sOut;
        }
        static readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите 3 целых числа (N K L) в одну строку через пробел (1 <= K <= L <= N)");
            try
            {
                int[] NKL = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (NKL[1] >= 1 && NKL[2] >= NKL[1] && NKL[0] > NKL[2])
                {
                    int[] N = new int[NKL[0]];
                    for (int i = 0; i < N.Length; i++)
                        N[i] = rnd.Next(0, 10);
                    foreach (var item in N)
                        Console.Write(item + " ");
                    float sum = 0;
                    for (int i = NKL[1]; i <= NKL[2]; i++)
                    {
                        sum += N[i];
                        Console.WriteLine(sum);
                    }
                    Console.WriteLine($"\nСреднее арифм. от {NKL[1]} до {NKL[2]}: " + sum / (NKL[2] - NKL[1] + 1));
                }
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //2
            Console.WriteLine("Задание 2)\n Введите размер массива N (N > 2)");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
                try
                {
                    int[] A = new int[n];
                    Console.WriteLine($"Введите {n} различных целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    if (A.Distinct().Count() != A.Length)
                        throw new ArgumentException("Не все элементы массива различны");
                    int x = A[1] - A[0];
                    for (int i = 2; i < A.Length; i++)
                    {
                        if (A[i] - A[i - 1] != x)
                        {
                            x = 0;
                            break;
                        }
                    }
                    Console.WriteLine(x);
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //3
            Console.WriteLine("Задание 3)\n Введите размер массива N (N > 2)");
            if (int.TryParse(Console.ReadLine(), out int n2) && n2 > 1)
                try
                {
                    int[] A = new int[n2];
                    Console.WriteLine($"Введите {n2} различных целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int min = int.MaxValue;
                    for (int i = 0; i < A.Length; i++)
                    {
                        // С нуля же?..
                        if (i % 2 == 0 && i != 0 && A[i] < min)
                            min = A[i];
                    }
                    Console.WriteLine($"Минимальное значение четного элемента в массиве: {min}");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //4
            Console.WriteLine("Задание 4)\n Введите размер массива N (N > 2)");
            if (int.TryParse(Console.ReadLine(), out int n3) && n3 > 1)
                try
                {
                    int[] A = new int[n3];
                    Console.WriteLine($"Введите {n3} различных целых чисел через пробел");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int localMax = int.MinValue;
                    for (int i = 1; i < A.Length; i++)
                    {

                        if (A[A.Length - 1] > A[A.Length - 2])
                        {
                            localMax = A[A.Length - 1];
                            break;
                        }
                        if (A[i] > A[i - 1] && i != A.Length - 1 && A[i] > A[i + 1])
                            localMax = A[i];
                    }
                    if (localMax != int.MinValue)
                        Console.WriteLine($"Последний локальный максимум: {localMax}");
                    else
                        Console.WriteLine("Не существует");
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
            //5
            Console.WriteLine("Задание 5)\n Введите размер массива N (N > 2)");
            if (int.TryParse(Console.ReadLine(), out int n4) && n4 > 1)
                try
                {
                    int[] A = new int[n4];
                    Console.WriteLine($"Введите {n4} целых чисел через пробел (не забудьте два одинаковых)");
                    A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine(Task5(A));
                }
                catch (Exception) { Console.WriteLine("Ошибка"); }
        }
    }
}