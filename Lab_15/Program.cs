using System;

namespace Lab_15
{
    class Point
    {
        string name = "";
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }

        public Point(string p)
        {
            x = int.Parse(p.Trim(' ').Split(' ')[0]);
            y = int.Parse(p.Trim(' ').Split(' ')[1]);
        }

        public override string ToString() => $"{X} {Y}";
    }

    class Program
    {
        //1
        static void PowerA3(double A, out double B) => B = A * A * A;

        //2
        static int Sign(float X) => X >= 0 ? X == 0 ? 0 : 1 : -1;

        //3
        static double RingS(float R1, float R2) => Math.PI * (R1 + R2) * (R1 - R2);

        //4
        static int Quarter(int x, int y) => (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x < 0 && y < 0) ? 3 : 4;

        //5
        static double Fact2(int N) => N % 2 == 0 ? N <= 2 ? 2 : N * Fact2(N - 2) : N <= 1 ? 1 : N * Fact2(N - 2);

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите 5 чисел в одну строку через пробел");
            try
            {
                double B;
                double[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                foreach (var item in ABC)
                {
                    PowerA3(item, out B);
                    Console.WriteLine($"{item} ^ 3 = {B}");
                }
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 5 чисел через пробел"); }
            //2
            Console.WriteLine("Задание 2)\n Введите число A");
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                Console.WriteLine(" Введите число B");
                if (float.TryParse(Console.ReadLine(), out float b))
                    Console.WriteLine(Sign(a) + Sign(b));
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" Введите внешний радиус {i + 1} кольца");
                if (float.TryParse(Console.ReadLine(), out float r1))
                {
                    Console.WriteLine($" Введите внутренний радиус {i + 1} кольца");
                    if (float.TryParse(Console.ReadLine(), out float r2) && r2 < r1)
                        Console.WriteLine("Площадь кольца: " + RingS(r1, r2));
                    else
                        Console.WriteLine("Error");
                }
                else
                    Console.WriteLine("Error");
            }
            //4
            Console.WriteLine("Задание 4)\n Введите 3 пары координат (x1 y1;x2 y2;x3 y3;) в одну строку через ';'");
            try
            {
                string[] input = Console.ReadLine().Split(';');
                Point[] points = { new Point(input[0]) { Name = "A" }, new Point(input[1]) { Name = "B" }, new Point(input[2]) { Name = "C" } };
                Console.WriteLine($"A: {Quarter(points[0].X, points[0].Y)} четверть\n" +
                                  $"B: {Quarter(points[1].X, points[1].Y)} четверть\n" +
                                  $"C: {Quarter(points[2].X, points[2].Y)} четверть");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Неверный формат ввода"); }
            //5
            Console.WriteLine("Задание 5)\n Введите число A");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                Console.WriteLine(Fact2(n));
            else
                Console.WriteLine("Error");
        }
    }
}
