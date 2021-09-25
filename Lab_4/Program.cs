using System;

namespace Lab_4
{
    class Program
    {
        /// <summary>
        /// Вычисляет площадь прямоугольника по двум его сторонам.
        /// </summary>
        /// <param name="a">сторона a прямоугольника</param>
        /// <param name="b">сторона b прямоугольника</param>
        /// <returns>Площадь прямоугольника S = a * b</returns>
        public static int Square(int a, int b) => a * b;

        /// <summary>
        /// Вычисляет периметр прямоугольника по двум его сторонам.
        /// </summary>
        /// <param name="a">сторона a прямоугольника</param>
        /// <param name="b">сторона b прямоугольника</param>
        /// <returns>Периметр прямоугольника P = (a + b) * 2</returns>
        public static int Perimeter(int a, int b) => 2 * (a + b);

        /// <summary>
        /// Вычисляет длину окружности по её диаметру.
        /// </summary>
        /// <param name="d">Диаметр окружности</param>
        /// <returns>Длина окружности L = pi * d</returns>
        public static double Length(int d) => 3.14 * d;

        /// <summary>
        /// Вычисляет среднее арфиметическое двух чисел.
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Среднее арфиметическое двух чисел (a + b) / 2</returns>
        public static double Task3(double a, double b) => (a + b) / 2;

        /// <summary>
        /// Вычисляет сумму, разность, произведение и частное квадратов двух ненулевых чисел.
        /// </summary>
        /// <param name="a">Первое ненулевое число</param>
        /// <param name="b">Второе ненулевое число</param>
        /// <returns>Нет (см. описание функции)</returns>
        public static void Task4(double a, double b)
        {
            if (a != 0 && b != 0)
            {
                double c = a * a;
                double d = b * b;
                Console.WriteLine($"4) " +
                    $"\n  +: {c + d}" +
                    $"\n  -: {c - d}" +
                    $"\n  *: {c * d}" +
                    $"\n  /: {c / d}");
            }
            else
                Console.WriteLine("Zero!");
        }

        /// <summary>
        /// Вычисляет сумму, разность, произведение и частное модулей двух ненулевых чисел.
        /// </summary>
        /// <param name="a">Первое ненулевое число</param>
        /// <param name="b">Второе ненулевое число</param>
        /// <returns>Нет (см. описание функции)</returns>
        public static void Task5(double a, double b)
        {
            if (a != 0 && b != 0)
            {
                double c = Math.Abs(a);
                double d = Math.Abs(b);
                Console.WriteLine($"5) " +
                    $"\n  +: {c + d}" +
                    $"\n  -: {c - d}" +
                    $"\n  *: {c * d}" +
                    $"\n  /: {c / d}");
            }
            else
                Console.WriteLine("Zero!");
        }

        public static void Main()
        {
            Console.WriteLine("1) Square: " + Square(2, 3)
                              + "\n   Prerimeter: " + Perimeter(2, 3)
                              + "\n2) " + Length(3)
                              + "\n3) " + Task3(2, -3));
            Task4(5, 6);
            Task5(6, 7);
        }
    }
}
