using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\nВведите размер файла в байтах");
            if (int.TryParse(Console.ReadLine(), out int bt))
                Console.WriteLine($"Кол-во полных Кб: {bt / 1024}");
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\n Введите целое положительное число A");
            if (uint.TryParse(Console.ReadLine(), out uint a))
            {
                Console.WriteLine("Введите целое положительное число B (B < A)");
                if (uint.TryParse(Console.ReadLine(), out uint b) && b < a)
                    Console.WriteLine($"кол-во отрезков длины B на отрезке длины А: {(a / b)}");
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)\n Введите целое положительное число A");
            if (uint.TryParse(Console.ReadLine(), out uint a1))
            {
                Console.WriteLine("Введите целое положительное число B (B < A)");
                if (uint.TryParse(Console.ReadLine(), out uint b1) && b1 < a1)
                    Console.WriteLine($"Оставшееся пространство: {(a1 % b1)}");
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //4
            Console.WriteLine("Задание 4)\nВведите целое двузначное число");
            if (int.TryParse(Console.ReadLine(), out int twoD))
            {
                int dec = twoD / 10;
                Console.WriteLine($"Результат 4: {(twoD % 10) * 10 + dec}");
            }
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)\nВведите целое трехзначное число");
            if (int.TryParse(Console.ReadLine(), out int threeD))
            {
                int dec = threeD / 100;
                Console.WriteLine($"Результат 5: {(threeD % 100) * 10 + dec}");
            }
            else
                Console.WriteLine("Error");
        }
    }
}