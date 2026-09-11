using System;

namespace DZ1
{
    internal class Лабораторная1
    {
        public static void ВыполнитьЛабораторную()
        {

            //Упражнение 2.1
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine();

            //Упражнение 2.2
            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Введите первое число");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                double result = (double)(num1 / num2);
                Console.WriteLine($"Результат деления: {result}");
            }
            Console.WriteLine();

            //Домашнее задание 2.1
            Console.WriteLine("Домашнее задание 2.1 ");
            Console.WriteLine("Введите букву");
            char ch = char.Parse(Console.ReadLine());
            char nextch;
            if (ch == 'я')
            {
                nextch = 'а';
            }
            else if (ch == 'Я')
            {
                nextch = 'А';
            }
            else
            {
                nextch = (char)(ch + 1);
            }
            Console.WriteLine($"Следующая буква: {nextch}");

            //Домашнее задание 2.2
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
        }
    }
}
        
    

