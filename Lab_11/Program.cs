using System;

namespace Lab_11
{
    class Point
    {
        string name = "";
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }

        public double Distance(Point point) => Math.Sqrt((point.x - x) * (point.x - x) + (point.y - y) * (point.y - y));

        public Point(string p)
        {
            x = int.Parse(p.Trim(' ').Split(' ')[0]);
            y = int.Parse(p.Trim(' ').Split(' ')[1]);
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите 2 целых числа (A B) в одну строку через пробел");
            try
            {
                int[] AB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine($"Было\nA: {AB[0]}, B: {AB[1]}");
                if (AB[0] == AB[1])
                {
                    AB[0] = 0;
                    AB[1] = 0;
                    Console.WriteLine($"Стало\nA: {AB[0]}, B: {AB[1]}");
                }
                else
                {
                    if (AB[0] > AB[1])
                        AB[1] = AB[0];
                    else
                        AB[0] = AB[1];
                    Console.WriteLine($"Стало\nA: {AB[0]}, B: {AB[1]}");
                }
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 2 целых числа через пробел"); }
            //2
            Console.WriteLine("Задание 2)\n Введите 3 числа (A B C) в одну строку через пробел");
            try
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int sum = 0;
                foreach (var item in ABC)
                    if (item != Math.Min(Math.Min(ABC[0], ABC[1]), ABC[2]))
                        sum += item;
                Console.WriteLine("Сумма двух наибольших: " + sum);
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых числа через пробел"); }
            //3
            Console.WriteLine("Задание 3)\n Введите 3 пары координат (x1 y1;x2 y2;x3 y3;) в одну строку через ';'");
            try
            {
                string[] input = Console.ReadLine().Split(';');
                Point[] points = { new Point(input[0]) { Name = "A" }, new Point(input[1]) { Name = "B" }, new Point(input[2]) { Name = "C" } };
                if (points[0].Distance(points[1]) <= points[0].Distance(points[2]))
                    Console.WriteLine($"B (distance = {points[0].Distance(points[1])})");
                else
                    Console.WriteLine($"C (distance = {points[0].Distance(points[2])})");

            }
            catch (Exception) { Console.WriteLine("Ошибка: Неверный формат ввода"); }
            //4
            Console.WriteLine("Задание 4)\n Введите пару координат (x y) в одну строку (x,y не равны 0)");
            try
            {
                string[] input = Console.ReadLine().Split(';');
                Point a = new Point(input[0]);
                Console.WriteLine((a.X > 0 && a.Y > 0) ? "Первая четверть" : (a.X < 0 && a.Y > 0) ? "Вторая чертверть" : (a.X < 0 && a.Y < 0) ? "Третья четверть" : "Четвертая четверть");
            }
            catch (Exception) { Console.WriteLine("Ошибка: Неверный формат ввода"); }
            //5
            Console.WriteLine("Задание 5)\n Введите целое число");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num == 0)
                    Console.WriteLine("Нулевое число");
                else
                    Console.WriteLine(num > 0 ? num % 2 == 0 ? "Положительное четное число" : "Положительное нечетное число" : num % 2 == 0 ? "Отрицательное четное число" : "Отрицательное нечетное число");
            }
            else
                Console.WriteLine("Error");
            //6
            Console.WriteLine("Задание 6)\n Введите целое число");
            if (int.TryParse(Console.ReadLine(), out int num2) && num2 > 0 && num2 < 1000)
            {
                switch (num2.ToString().Length)
                {
                    case 1:
                        Console.WriteLine(num2 % 2 == 0 ? "Четное однозначное число" : "Нечетное однозначое число");
                        break;
                    case 2:
                        Console.WriteLine(num2 % 2 == 0 ? "Четное двузначное число" : "Нечетное двузначое число");
                        break;
                    case 3:
                        Console.WriteLine(num2 % 2 == 0 ? "Четное трехзначное число" : "Нечетное трехзначое число");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            else
                Console.WriteLine("Error");
        }
    }
}
