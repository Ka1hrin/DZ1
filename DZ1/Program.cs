using System;
using System.Threading;

public class Латыпова
{
    static void Main()
    {
        Random rnd = new Random(); //Сразу для нескольких заданий

        //Задание 1
        Console.WriteLine("Задание 1");
        Console.WriteLine(Math.Round(Math.E, 1));
        Console.WriteLine(); //просто пробел для удобства просмотра ответов

        //Задание 2
        Console.WriteLine("Задание 2");
        Console.WriteLine(50);
        Console.WriteLine(10);
        Console.WriteLine();

        //Задание 3
        Console.WriteLine("Задание 3");
        Console.WriteLine(rnd.Next());
        Console.WriteLine(rnd.Next());
        Console.WriteLine(rnd.Next());
        Console.WriteLine(rnd.Next());
        Console.WriteLine();

        //Задание 4
        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num + 10);
        Console.WriteLine();

        //Задание 5
        Console.WriteLine("Задание 5");
        Console.WriteLine("Введите любое число");
        double num5 = double.Parse(Console.ReadLine());
        double y = Math.Cos(num5); //Выводит косинус, ввод в радианах
        Console.WriteLine(y);
        Console.WriteLine();

        //Задание 6
        Console.WriteLine("Задание 6");
        Console.WriteLine("Введите длину меньшего основания");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину большего основания");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину высоты");
        double h = double.Parse(Console.ReadLine());
        double diff = b - a;
        double bokstorona = Math.Sqrt(h * h + (diff / 2) * (diff / 2));
        double perimetr = 2 * bokstorona + a + b;
        Console.WriteLine($"Периметр трапеции равен: {perimetr} ");
        Console.WriteLine();

        //Задание 7
        Console.WriteLine("Задание 7");
        Console.WriteLine("Мир\tТруд\tМай");
        Console.WriteLine("{0,-10}", "Мир");
        Console.WriteLine("{0,10}", "Труд");
        Console.WriteLine("{0,20}", "Май");
        Console.WriteLine();


        //Задание 8
        Console.WriteLine("Задание 8");
        Console.WriteLine("Введите первое число");
        int num6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num7 = int.Parse(Console.ReadLine());
        (num6, num7) = (num7, num6);
        Console.WriteLine(num6);
        Console.WriteLine(num7);
        Console.WriteLine();

        //Задание 9
        Console.WriteLine("Задание 9");
        Console.WriteLine("Введите число");
        int num8 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Вы ввели число: {num8} ");
        Console.WriteLine();

        //Задание 10
        Console.WriteLine("Задание 10");
        Console.WriteLine("Введите коэффициенты квадратного уравнения через Enter");
        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());

        if (coefA == 0)
        {
            Console.WriteLine("Это не квадратное уравнение (a не может быть 0).");
        }
        else
        {
            double dis = coefB * coefB - 4 * coefA * coefC;

            if (dis > 0)
            {
                double x21 = (-coefB + Math.Sqrt(dis)) / (2 * coefA);
                double x22 = (-coefB - Math.Sqrt(dis)) / (2 * coefA);
                Console.WriteLine($"Корень квадратного уравнения х1: {x21}");
                Console.WriteLine($"Корень квадратного уравнения х2: {x22}");
            }
            else if (dis == 0)
            {
                double x = -coefB / (2 * coefA);
                Console.WriteLine($"Один корень: {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет.");
            }
        }
        Console.WriteLine();

        //Задание 11
        Console.WriteLine("Задание 11");
        Console.WriteLine("Введите первое число");
        int num10 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num11 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Среднее арифметическое введенных чисел: {(num10 + num11) / 2.0} ");
        Console.WriteLine($"Среднее геометрическое введенных чисел: {Math.Sqrt(num10 * num11)} ");
        Console.WriteLine();

        //Задание 12
        Console.WriteLine("Задание 12");
        Console.WriteLine("Введите координаты х первой точки");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты у первой точки");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты х второй точки");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты у второй точки");
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))} ");
        Console.WriteLine();

        //Задание 13
        Console.WriteLine("Задание 13");
        Console.WriteLine("Введите первое число");
        int a2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int b2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        int c2 = int.Parse(Console.ReadLine());
        int origA = a2, origB = b2, origC = c2;
        (b2, a2, c2) = (c2, b2, a2);
        Console.WriteLine($"Схема а: {a2}, {b2}, {c2}");
        a2 = origA; b2 = origB; c2 = origC;
        (a2, b2, c2) = (c2, a2, b2);
        Console.WriteLine($"Схема б: {a2}, {b2}, {c2}");
        Console.WriteLine();

        //Задание 14
        Console.WriteLine("Задание 14");
        Console.WriteLine("Введите количество секунд");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Прошло часов: {n / 3600} ");
        Console.WriteLine($"После начала последнего часа прошло минут: {n % 3600 / 60} ");
        Console.WriteLine($"После последней минуты прошло секунд: {n % 3600 % 60} ");
        Console.WriteLine();

        //Задание 15
        Console.WriteLine("Задание 15");
        byte kw = (byte) (543 / 130);
        Console.WriteLine($"Количество квадратов: {kw}");
        Console.WriteLine();

        //Задание 16
        Console.WriteLine("Задание 16");
        Console.WriteLine("Введите трехзначное число");
        int num12 = int.Parse(Console.ReadLine());
        int result = (num12 % 10) * 100 + num12 / 10;
        Console.WriteLine($"Полученное число: {result}");
        Console.WriteLine();

        //Задание 17
        Console.WriteLine("Задание 17");
        Console.WriteLine("Введите число больше 999");
        int num13 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Количество сотен: {num13 / 100} ");
        Console.WriteLine($"Количество тысяч: {num13 / 1000} ");
        Console.WriteLine();

        //Задание 18
        Console.WriteLine("Задание 18");
        Console.WriteLine("Введите имя");
        string name1 = Console.ReadLine();
        Console.WriteLine(name1);
        Console.WriteLine("Введите имя");
        string name2 = Console.ReadLine();
        Console.WriteLine($"Привет, {name2}!");
        Console.WriteLine();

        //Задание 19
        Console.WriteLine("Задание 19");
        Console.WriteLine("Введите приветствие");
        Console.ReadLine();
        Console.WriteLine("Введите имя");
        string name3 = Console.ReadLine();
        Console.WriteLine($"привет, {name3}! ");
        Console.WriteLine("Введите свой вопрос");
        Console.ReadLine();
        Console.WriteLine("Да");
        Console.WriteLine("Введите свой вопрос");
        Console.ReadLine();
        Console.WriteLine("Нет");
        Thread.Sleep(5000);
        Console.BackgroundColor = (ConsoleColor)rnd.Next(16);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("но могу показать");
        Console.ResetColor();
        Console.WriteLine();

        //Задание 20
        Console.WriteLine("Задание 20");
        byte code1 = (byte)rnd.Next(0, 10);
        byte code2 = (byte)rnd.Next(0, 10);
        byte code3 = (byte)rnd.Next(0, 10);
        byte code4 = (byte)rnd.Next(0, 10);
        byte code5 = (byte)rnd.Next(0, 10);
        byte code6 = (byte)rnd.Next(0, 10);
        byte code7 = (byte)rnd.Next(0, 10);
        byte code8 = (byte)rnd.Next(0, 10);
        byte code9 = (byte)rnd.Next(0, 10);
        byte code10 = (byte)rnd.Next(0, 10);
        byte code11 = (byte)rnd.Next(0, 10);
        byte code12 = (byte)rnd.Next(0, 10);
        int sumchet = (code2 + code4 + code6 + code8 + code10 + code12) * 3;
        int sumnechet = (code1 + code3 + code5 + code7 + code9 + code11);
        int sum4 = sumchet + sumnechet;
        int lastnum = ((sum4 + 9) / 10) * 10 - sum4;
        Console.WriteLine($"Контрольная цифра штрихкода: {lastnum} ");
        Console.WriteLine("Введите 12 цифр через Enter");
        byte number1 = byte.Parse(Console.ReadLine());
        byte number2 = byte.Parse(Console.ReadLine());
        byte number3 = byte.Parse(Console.ReadLine());
        byte number4 = byte.Parse(Console.ReadLine());
        byte number5 = byte.Parse(Console.ReadLine());
        byte number6 = byte.Parse(Console.ReadLine());
        byte number7 = byte.Parse(Console.ReadLine());
        byte number8 = byte.Parse(Console.ReadLine());
        byte number9 = byte.Parse(Console.ReadLine());
        byte number10 = byte.Parse(Console.ReadLine());
        byte number11 = byte.Parse(Console.ReadLine());
        byte number12 = byte.Parse(Console.ReadLine());
        int sum5 = (number2 + number4 + number6 + number8 + number10 + number12) * 3;
        int sum6 = (number1 + number3 + number5 + number7 + number9 + number11);
        int sum7 = sum5 + sum6;
        int lastnum2 = ((sum7 + 9) / 10) * 10 - sum7;
        Console.WriteLine($"Контрольная цифра штрихкода: {lastnum2} ");
        Console.ReadKey();


    }
}
