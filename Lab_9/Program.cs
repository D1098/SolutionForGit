using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1)\n Введите число прошедших секунд с начала дня (N<86400)");
            if (uint.TryParse(Console.ReadLine(), out uint bt) && bt < 86400)
                Console.WriteLine($"Кол-во прошедших секунд с начала последней минуты: {bt % 60}");
            else
                Console.WriteLine("Error");
            //2
            Console.WriteLine("Задание 2)\n Введите K (день года 1 <= K <= 365)");
            if (uint.TryParse(Console.ReadLine(), out uint k) && k >= 1 && k <= 365)
            {
                uint day = k % 7;
                switch (day)
                {
                    case 0:
                        Console.WriteLine("Это воскресенье");
                        break;
                    case 1:
                        Console.WriteLine("Это понедельник");
                        break;
                    case 2:
                        Console.WriteLine("Это вторник");
                        break;
                    case 3:
                        Console.WriteLine("Это среда");
                        break;
                    case 4:
                        Console.WriteLine("Это четверг");
                        break;
                    case 5:
                        Console.WriteLine("Это пятница");
                        break;
                    case 6:
                        Console.WriteLine("Это суббота");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            else
                Console.WriteLine("Error");
            //3
            Console.WriteLine("Задание 3)\n Введите целое положительное число n (1 <= n <= 7)");
            if (uint.TryParse(Console.ReadLine(), out uint n) && n >= 1 && n <= 7)
            {
                Console.WriteLine(" Введите K (день года 1 <= K <= 365)");
                if (uint.TryParse(Console.ReadLine(), out uint k1) && k1 >= 1 && k1 <= 365)
                {
                    uint day = ((k1 + n - 1) % 7);
                    switch (day)
                    {
                        case 0:
                            Console.WriteLine("Это воскресенье");
                            break;
                        case 1:
                            Console.WriteLine("Это понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Это вторник");
                            break;
                        case 3:
                            Console.WriteLine("Это среда");
                            break;
                        case 4:
                            Console.WriteLine("Это четверг");
                            break;
                        case 5:
                            Console.WriteLine("Это пятница");
                            break;
                        case 6:
                            Console.WriteLine("Это суббота");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;

                    }
                }
                else
                    Console.WriteLine("Error");
            }
            else
                Console.WriteLine("Error");
            //4
            Console.WriteLine("Задание 4)\n Введите 3 целых положительных числа (A B C) в одну строку через пробел");
            try
            {
                uint[] ABC = Array.ConvertAll(Console.ReadLine().Split(' '), uint.Parse);
                Console.WriteLine("Кол-во квадратов: " + (ABC[0] * ABC[1]) / (ABC[2] * ABC[2]) +
                                  "\nОставшаяса площадь: " + (ABC[0] * ABC[1]) % (ABC[2] * ABC[2]));
            }
            catch (Exception) { Console.WriteLine("Ошибка: Необходимо ввести 3 целых положительных числа через пробел"); }
            //5
            Console.WriteLine("Задание 5)\n Введите номер года");
            if (uint.TryParse(Console.ReadLine(), out uint year))
                Console.WriteLine($"Номер столетия:  {((year - 1) / 100) + 1}");
            else
                Console.WriteLine("Error");
        }
    }
}