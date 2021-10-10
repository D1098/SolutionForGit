using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] output = new string[3];
            Console.WriteLine("Задание 1)\n Введите номер дня (от 1 до 31)");
            if (uint.TryParse(Console.ReadLine(), out uint day) && day >= 1 && day <= 31)
            {
                Console.WriteLine(" Введите номер месяца (от 1 до 12)");
                if (uint.TryParse(Console.ReadLine(), out uint m) && m >= 1 && m <= 12)
                {
                    switch (day % 10)
                    {
                        case 0:
                            switch (day)
                            {
                                case 10:
                                    output[1] = "Десятое";
                                    break;
                                case 20:
                                    output[1] = "Двадцатое";
                                    break;
                                case 30:
                                    output[1] = "Тридцатое";
                                    break;
                            }
                            break;
                        case 1:
                            output[1] = "Первое";
                            break;
                        case 2:
                            output[1] = "Второе";
                            break;
                        case 3:
                            output[1] = "Третье";
                            break;
                        case 4:
                            output[1] = "Четвертое";
                            break;
                        case 5:
                            output[1] = "Пятое";
                            break;
                        case 6:
                            output[1] = "Шестое";
                            break;
                        case 7:
                            output[1] = "Седьмое";
                            break;
                        case 8:
                            output[1] = "Восьмое";
                            break;
                        case 9:
                            output[1] = "Девятое";
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    if (day > 10 && day != 20 && day != 30)
                        switch (day / 10)
                        {
                            case 1:
                                switch (day % 10)
                                {
                                    case 1:
                                        output[1] = "Одиннадцатое";
                                        break;
                                    case 2:
                                        output[1] = "Двенадцатое";
                                        break;
                                    case 3:
                                        output[1] = "Тринадцатое";
                                        break;
                                    case 4:
                                        output[1] = "Четырнадцатое";
                                        break;
                                    case 5:
                                        output[1] = "Пятнадцатое";
                                        break;
                                    case 6:
                                        output[1] = "Шестнадцатое";
                                        break;
                                    case 7:
                                        output[1] = "Семнадцатое";
                                        break;
                                    case 8:
                                        output[1] = "Восемнадцатое";
                                        break;
                                    case 9:
                                        output[1] = "Девятнадцатое";
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка");
                                        break;
                                }
                                break;
                            case 2:
                                output[0] = "Двадцать";
                                break;
                            case 3:
                                output[0] = "Тридцать";
                                break;
                        }
                    switch (m)
                    {
                        case 1:
                            output[2] = "Января";
                            break;
                        case 2:
                            output[2] = "Февраля";
                            break;
                        case 3:
                            output[2] = "Марта";
                            break;
                        case 4:
                            output[2] = "Апреля";
                            break;
                        case 5:
                            output[2] = "Мая";
                            break;
                        case 6:
                            output[2] = "Июня";
                            break;
                        case 7:
                            output[2] = "Июля";
                            break;
                        case 8:
                            output[2] = "Августа";
                            break;
                        case 9:
                            output[2] = "Сентябра";
                            break;
                        case 10:
                            output[2] = "Октября";
                            break;
                        case 11:
                            output[2] = "Ноября";
                            break;
                        case 12:
                            output[2] = "Декабря";
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

            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
            //2
            string[] direction = { "C", "З", "Ю", "В", "C", "З", "Ю", "В", "C", "З", "Ю", "В" };
            int currDir = 0;
            Console.WriteLine("\nЗадание 2)\n Введите начальное положение робота (С, З, Ю, В)");
            string dir = Console.ReadLine();
            if (dir == "С" || dir == "З" || dir == "Ю" || dir == "В")
            {
                switch (dir)
                {
                    case "С":
                        currDir = 4;
                        break;
                    case "З":
                        currDir = 5;
                        break;
                    case "Ю":
                        currDir = 6;
                        break;
                    case "В":
                        currDir = 7;
                        break;
                }
                try
                {
                    Console.WriteLine("Введите последовательность команд через пробел (-1, 0, 1)");
                    int sum = 0;
                    int[] instructions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    foreach (var item in instructions)
                        sum += item;
                    sum = sum % 4;
                    currDir += sum;
                    Console.WriteLine(direction[currDir]);
                }
                catch (Exception) { Console.WriteLine("Error"); }
            }
            else
                Console.WriteLine("Error");
            //3
            string[] output2 = new string[3];
            Console.WriteLine("Задание 3)\n Введите кол-во заданий (от 1 до 40)");
            if (uint.TryParse(Console.ReadLine(), out uint num) && num >= 1 && num <= 40)
            {
                switch (num % 10)
                {
                    case 0:
                        switch (num)
                        {
                            case 10:
                                output2[1] = "Десять";
                                break;
                            case 20:
                                output2[1] = "Двадцать";
                                break;
                            case 30:
                                output2[1] = "Тридцать";
                                break;
                            case 40:
                                output2[1] = "Сорок";
                                break;
                        }
                        break;
                    case 1:
                        output2[1] = "Одно";
                        break;
                    case 2:
                        output2[1] = "Два";
                        break;
                    case 3:
                        output2[1] = "Три";
                        break;
                    case 4:
                        output2[1] = "Четыре";
                        break;
                    case 5:
                        output2[1] = "Пять";
                        break;
                    case 6:
                        output2[1] = "Шесть";
                        break;
                    case 7:
                        output2[1] = "Семь";
                        break;
                    case 8:
                        output2[1] = "Восемь";
                        break;
                    case 9:
                        output2[1] = "Девять";
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                if (num > 10 && num != 20 && num != 30 && num != 40)
                    switch (num / 10)
                    {
                        case 1:
                            switch (num % 10)
                            {
                                case 1:
                                    output2[1] = "Одиннадцать";
                                    break;
                                case 2:
                                    output2[1] = "Двенадцать";
                                    break;
                                case 3:
                                    output2[1] = "Тринадцать";
                                    break;
                                case 4:
                                    output2[1] = "Четырнадцать";
                                    break;
                                case 5:
                                    output2[1] = "Пятнадцать";
                                    break;
                                case 6:
                                    output2[1] = "Шестнадцать";
                                    break;
                                case 7:
                                    output2[1] = "Семнадцать";
                                    break;
                                case 8:
                                    output2[1] = "Восемнадцать";
                                    break;
                                case 9:
                                    output2[1] = "Девятнадцать";
                                    break;
                                default:
                                    Console.WriteLine("Ошибка");
                                    break;
                            }
                            break;
                        case 2:
                            output2[0] = "Двадцать";
                            break;
                        case 3:
                            output2[0] = "Тридцать";
                            break;
                        case 4:
                            output2[0] = "Сорок";
                            break;
                    }

                if (output2[1].EndsWith('ь') || output2[1].EndsWith('к'))
                    output2[2] = "Заданий";
                if (output2[1].EndsWith('о'))
                    output2[2] = "Задание";
                if (output2[1].EndsWith('а') || output2[1].EndsWith('и') || output2[1].EndsWith('е'))
                    output2[2] = "Задания";
            }
            else
                Console.WriteLine("Error");

            foreach (var item in output2)
                Console.Write(item + " ");
            //4
            string[] output3 = new string[3];
            Console.WriteLine("\nЗадание 4)\n Введите число (от 100 до 999)");
            if (uint.TryParse(Console.ReadLine(), out uint num3) && num3 >= 100 && num3 <= 999)
            {
                switch (num3 / 100)
                {
                    case 1:
                        output3[2] = "Сто";
                        break;
                    case 2:
                        output3[2] = "Двести";
                        break;
                    case 3:
                        output3[2] = "Триста";
                        break;
                    case 4:
                        output3[2] = "Четыреста";
                        break;
                    case 5:
                        output3[2] = "Пятьсот";
                        break;
                    case 6:
                        output3[2] = "Шестьсот";
                        break;
                    case 7:
                        output3[2] = "Семьсот";
                        break;
                    case 8:
                        output3[2] = "Восемьсот";
                        break;
                    case 9:
                        output3[2] = "Девятьсот";
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                switch (num3 % 10)
                {
                    case 0:
                        switch ((num3 / 10) % 10)
                        {
                            case 10:
                                output3[1] = "Десять";
                                break;
                            case 20:
                                output3[1] = "Двадцать";
                                break;
                            case 30:
                                output3[1] = "Тридцать";
                                break;
                            case 40:
                                output3[1] = "Сорок";
                                break;
                            case 50:
                                output3[1] = "Пятьдесят";
                                break;
                            case 60:
                                output3[1] = "Шетьдесят";
                                break;
                            case 70:
                                output3[1] = "Семьдесят";
                                break;
                            case 80:
                                output3[1] = "Восемдесят";
                                break;
                            case 90:
                                output3[1] = "Девяносто";
                                break;
                        }
                        break;
                    case 1:
                        output3[1] = "Один";
                        break;
                    case 2:
                        output3[1] = "Два";
                        break;
                    case 3:
                        output3[1] = "Три";
                        break;
                    case 4:
                        output3[1] = "Четыре";
                        break;
                    case 5:
                        output3[1] = "Пять";
                        break;
                    case 6:
                        output3[1] = "Шесть";
                        break;
                    case 7:
                        output3[1] = "Семь";
                        break;
                    case 8:
                        output3[1] = "Восемь";
                        break;
                    case 9:
                        output3[1] = "Девять";
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                if (num3 % 100 > 10 && num3 != 20 && num3 != 30 && num3 != 40 && num3 != 50 && num3 != 60 && num3 != 70 && num3 != 80 && num3 != 90)
                    switch (num3 % 100 / 10)
                    {
                        case 1:
                            switch (num3 % 10)
                            {
                                case 1:
                                    output3[1] = "Одиннадцать";
                                    break;
                                case 2:
                                    output3[1] = "Двенадцать";
                                    break;
                                case 3:
                                    output3[1] = "Тринадцать";
                                    break;
                                case 4:
                                    output3[1] = "Четырнадцать";
                                    break;
                                case 5:
                                    output3[1] = "Пятнадцать";
                                    break;
                                case 6:
                                    output3[1] = "Шестнадцать";
                                    break;
                                case 7:
                                    output3[1] = "Семнадцать";
                                    break;
                                case 8:
                                    output3[1] = "Восемнадцать";
                                    break;
                                case 9:
                                    output3[1] = "Девятнадцать";
                                    break;
                                default:
                                    Console.WriteLine("Ошибка");
                                    break;
                            }
                            break;
                        case 2:
                            output3[0] = "Двадцать";
                            break;
                        case 3:
                            output3[0] = "Тридцать";
                            break;
                        case 4:
                            output3[0] = "Сорок";
                            break;
                        case 5:
                            output3[0] = "Пятьдесят";
                            break;
                        case 6:
                            output3[0] = "Шестьдесят";
                            break;
                        case 7:
                            output3[0] = "Семьдесят";
                            break;
                        case 8:
                            output3[0] = "Восемьдесят";
                            break;
                        case 9:
                            output3[0] = "Девяносто";
                            break;
                    }
            }
            else
                Console.WriteLine("Error");

            Console.Write(output3[2] + " " + output3[0] + " " + output3[1]);
            //5
            string[] output4 = new string[2];
            Console.WriteLine("\nЗадание 5)\n Введите год (от 0 до 3000)");
            if (uint.TryParse(Console.ReadLine(), out uint year) && year <= 3000)
            {
                switch (year % 10)
                {
                    case 0:
                    case 1:
                        output4[0] = Year("Бел", year);
                        break;
                    case 2:
                    case 3:
                        output4[0] = Year("Черн", year);
                        break;
                    case 4:
                    case 5:
                        output4[0] = Year("Зелен", year);
                        break;
                    case 6:
                    case 7:
                        output4[0] = Year("Красн", year);
                        break;
                    case 8:
                    case 9:
                        output4[0] = Year("Желт", year);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                switch (year % 12)
                {
                    case 0:
                        output4[1] = "обезьяны";
                        break;
                    case 1:
                        output4[1] = "курицы";
                        break;
                    case 2:
                        output4[1] = "собаки";
                        break;
                    case 3:
                        output4[1] = "свиньи";
                        break;
                    case 4:
                        output4[1] = "крысы";
                        break;
                    case 5:
                        output4[1] = "коровы";
                        break;
                    case 6:
                        output4[1] = "тигра";
                        break;
                    case 7:
                        output4[1] = "зайца";
                        break;
                    case 8:
                        output4[1] = "дракона";
                        break;
                    case 9:
                        output4[1] = "змеи";
                        break;
                    case 10:
                        output4[1] = "лошади";
                        break;
                    case 11:
                        output4[1] = "овцы";
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                foreach (var item in output4)
                    Console.Write(item);
            }
            // Для склонения цветов животных (задание 5)
            string Year(string color, uint year)
            {
                if (year % 12 == 8 || year % 12 == 7 || year % 12 == 6)
                    return $"{color}ого ";
                else
                    return $"{color}ой ";
            }
        }
    }
}
