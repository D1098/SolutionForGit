using System;

namespace Lab5
{
    /// <summary>
    /// Шаблон точки.
    /// </summary>
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Point({X},{Y})";
    }
    class Program
    {
        /// <summary>
        /// Функция для нахождения расстояния между точками.
        /// </summary>
        /// <param name="a">Первая точка</param>
        /// <param name="b">Вторая точка</param>
        /// <returns></returns>
        static double Distance(Point a, Point b) => Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));

        static void Task2(Point a, Point b, Point c)
        {
            Console.WriteLine("2) \n AC = " + Distance(a, c)
                               + "\n BC = " + Distance(b, c)
                               + "\n AC + BC = " + Distance(a, c) + Distance(b, c));
        }

        static void Main()
        {
            //Задача 1
            Point a = new Point(-1, 2);
            Point b = new Point(3, -7);
            Console.WriteLine("1)\n " + Distance(a, b));
            //Задача 2
            Point c = new Point(4, 5);
            Task2(a, b, c);
            //Задача 3
            Point f = new Point(0, 0), g = new Point(1, 1), h = new Point(2, 2);
            Console.WriteLine("3)\n " + Distance(f, h) * Distance(g, h));
            //Задача 4
            Point x = new Point(6, 4), y = new Point(1, 1);
            Console.WriteLine("4)\n Периметр: "
                              + (Math.Abs(y.X - x.X) + Math.Abs(y.Y - x.Y)) * 2
                              + "\n Площадь: "
                              + (Math.Abs(y.X - x.X) * Math.Abs(y.Y - x.Y)));
            //Задача 5
            //Возьму a,b,c из задачи 1.
            double p = (Distance(a, b) + Distance(b, c) + Distance(c, a)) / 2;
            Console.WriteLine("5)\n Периметр: "
                              + p
                              + "\n Площадь: "
                              + Math.Sqrt(p * (p - Distance(a, b)) * (p - Distance(b, c)) * (p - Distance(c, a))));
        }
    }
}
