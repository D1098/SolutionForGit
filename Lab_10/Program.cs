using System;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите 2 целых числа (A B) в одну строку через пробел");
            try
            {
                int[] AB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (AB[0] > 2 && AB[1] <= 3)
                    Console.WriteLine("Справедливы неравенства A > 2 и B <= 3: Верно");
                else
                    Console.WriteLine("Справедливы неравенства A > 2 и B <= 3: Неверно");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 2 целых числа через пробел"); }
            //2
            Console.WriteLine("Задание 2)\n Введите 3 целых числа (A B C) в одну строку через пробел");
            try
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (ABC[0] < ABC[1] && ABC[1] < ABC[2])
                    Console.WriteLine("Справедливо двойное неравенство A < B < C: Верно");
                else
                    Console.WriteLine("Справедливо двойное неравенство A < B < C: Неверно");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //3
            Console.WriteLine("Задание 3)\n Введите целое число");
            if (uint.TryParse(Console.ReadLine(), out uint num))
                Console.WriteLine($"Данное число является четным двузначным: {((num.ToString().Length == 2 && num % 2 == 0) ? "Да" : "Нет")}");
            else
                Console.WriteLine("Error");
            //4
            Console.WriteLine("Задание 4)\n Введите целое трехзначное число");
            if (int.TryParse(Console.ReadLine(), out int num2) && num2.ToString().Length == 3)
                Console.WriteLine($"Цифры данного числа образуют возрастающую или убывающую последовательность: {(((num2 % 10 > (num2 / 10) % 10 && (num2 / 10) % 10 > num2 / 100) || (num2 % 10 < (num2 / 10) % 10 && (num2 / 10) % 10 < num2 / 100)) ? "Да" : "Нет")}");
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)\n Введите целое четырехзначное число");
            if (int.TryParse(Console.ReadLine(), out int num3) && num3.ToString().Length == 4)
                Console.WriteLine($"Данное число читается одинаково слева направо и справа налево: {((num3 / 100) == 10 * (num3 % 10) + (num3 / 10) % 10 ? "Да" : "Нет")}");
            else
                Console.WriteLine("Error");
            //6
            Console.WriteLine("Задание 6)\n Введите 3 целых числа (A B C) в одну строку через пробел");
            try
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (ABC[0] * ABC[0] + ABC[1] * ABC[1] == ABC[2] * ABC[2] || ABC[2] * ABC[2] + ABC[1] * ABC[1] == ABC[0] * ABC[0] || ABC[0] * ABC[0] + ABC[2] * ABC[2] == ABC[1] * ABC[1])
                    Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным: Верно");
                else
                    Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным: Неверно");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //7
            Console.WriteLine("Задание 7)\n Введите 3 целых числа (A B C) в одну строку через пробел");
            try
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (ABC[0] + ABC[1] > ABC[2] || ABC[2] + ABC[1] > ABC[0] || ABC[0] + ABC[2] > ABC[1])
                    Console.WriteLine("Существует треугольник со сторонами a, b, c: Верно");
                else
                    Console.WriteLine("Существует треугольник со сторонами a, b, c: Неверно");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
        }
    }
}
