using System;

namespace Lab_7
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\nВведите значение угла alfa в градусах (0 < alfa < 360)");
            if (int.TryParse(Console.ReadLine(), out int a) && a > 0 && a < 360)
                Console.WriteLine($"значение alfa в радианах: {a * Math.PI / 180}");
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\nВведите значение угла alfa в радианах (0 < alfa < 2*pi)");
            if (double.TryParse(Console.ReadLine(), out double al) && al > 0 && al < 2 * Math.PI)
                Console.WriteLine($"alfa в градусах: {al * 180 / Math.PI}");
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)\nИзвестно, что 5 кг. конфет стоит 120 рублей");
            int weight = 5, cost = 120;
            double pricePerKilo = cost / weight;
            Console.WriteLine($"Это {pricePerKilo} руб. за килограмм\nСколько кг. конфет вам нужно?");
            if (int.TryParse(Console.ReadLine(), out int targetWeight))
                Console.WriteLine($"C вас {targetWeight * pricePerKilo} руб.");
            else
                Console.WriteLine("Ошибка! Введите целое число.");
            //4
            Console.WriteLine("Задание 4)\nРасстояние между автомобилями - 5 км.\nВведите скорость первого автомобиля");
            if (uint.TryParse(Console.ReadLine(), out uint v1))
            {
                Console.WriteLine("Введите скорость второго автомобиля");
                if (uint.TryParse(Console.ReadLine(), out uint v2))
                    Console.WriteLine($"Расстояние между ними через 3 часа: {5 + (v1 + v2) * 3}");
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //5
            Console.WriteLine("Задание 5)");
            int aC = rnd.Next(1, 10), bC = rnd.Next(0, 10);
            Console.WriteLine($"Линейное уравнение: {aC}x + {bC} = 0 (Коэф. сгенерированы случайно)");
            Console.WriteLine($"Решение: {-1.0 * bC / aC}");
            //6
            Console.WriteLine("Задание 6)");
            int c1 = rnd.Next(1, 10), c2 = rnd.Next(1, 10), a1 = rnd.Next(1, 10), a2 = rnd.Next(1, 10), b1 = rnd.Next(1, 10), b2 = rnd.Next(1, 10);
            Console.WriteLine($"Cистема: {a1}x + {b1}y = {c1}\n {a2}x + {b2}y = {c2}\n(Коэф. сгенерированы случайно)");
            int delta = a1 * b2 - a2 * b1;
            Console.WriteLine($"Ответ: x = {1.0 * (c1 * b2 - c2 * b1) / delta}\n y = {1.0 * (a1 * c2 - a2 * c1) / delta}");
        }
    }
}
