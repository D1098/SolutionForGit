using System;

namespace Lab_6
{
    class Program
    {
        static void Main()
        {
            // Task 1
            int a = 0, b = 1;
            int mem = b;
            b = a;
            a = mem;
            Console.WriteLine($"a = {a}, b= {b}");
            // Task 2
            int c = 2;
            a = 0;
            b = 1;
            mem = b;
            b = a;
            a = c;
            c = mem;
            Console.WriteLine($"a = {a}, b= {b}, c = {c}");
            // Task 3
            a = 0;
            b = 1;
            c = 2;
            mem = c;
            c = a;
            a = b;
            b = mem;
            Console.WriteLine($"a = {a}, b= {b}, c = {c}");
            // Task 4 
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            double y4 = 3 * Math.Pow(x, 6) - 6 * x * x - 7;
            double y5 = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3) + 2;
            Console.WriteLine($" y4(x) = {y4}\n y5(x) = {y5}");
            // Task 5
            Console.WriteLine("Введите А");
            int A = int.Parse(Console.ReadLine());
            double help = Math.Pow(A, 8);
            double deg = help * 1 * 1 * 1;
            Console.WriteLine($"A^8 = {deg}");
            // Task 6
            double help1 = Math.Pow(A, 9);
            double help2 = Math.Pow(A, 2);
            double res = help1 * help2 * A * A * A * A;
            Console.WriteLine($"A^15 = {res}");
        }
    }
}