using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_3
{
    class Program
    {
        enum Cards
        {
            Шестерка = 6,
            Семерка,
            Восьмерка,
            Девятка,
            Десятка,
            Валет,
            Дама,
            Король,
            Туз
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\nВведите трехзначное число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if ((num3 / 100) == (num3 % 10))
                Console.WriteLine(num3 + " - число-палиндром");
            else Console.WriteLine(num3 + " не является палиндромом");
            Console.WriteLine("Задание 2\nВведите параметры окна (a,b):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы (d):");
            int d = Convert.ToInt32(Console.ReadLine());
            if ((a - d) >= 2 && (b - d) >= 2)
            {
                Console.WriteLine("У него получится это сделать");
            }
            else { Console.WriteLine("У него не получится это сделать"); }
            Console.WriteLine("\nЗадание 3\nВведите число от 1 до 7");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
            Console.WriteLine("Задание 4\nВведите номер карты:");
            try
            {

                a = Convert.ToInt32(Console.ReadLine());

                if (a < 6 || a > 14)
                { throw new Exception("\nТакой карты нет\n"); }
                else
                { Console.WriteLine((Cards)a); }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            Console.WriteLine("\nЗадание 5\nВведите высоту");
            int radius = 6370;
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Расстояние до линии горизонта равно{Math.Sqrt((radius * height) * (radius * height) - radius * radius)}" +
                $"\nЗадание 6\nВведите цифру n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 9)
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(n + " * " + i + " = " + n * i);
                }
            else
                Console.WriteLine("Неверный ввод\nЗадание 7\nВведите первое число последовательности:");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                int sum = 0, count = 0;
                while (n >= 0)
                {
                    sum += n; count++;
                    Console.WriteLine("Введите следуещее число в последовательности:");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Cреднее значение = " + sum / count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
            Console.WriteLine("Задание 8\nВведите первый член последовательности:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < 11; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                if (m <= n)
                {
                    Console.WriteLine("Последовательность не возрастает, номер первого числа, которое нарушает данную последовательность " + i);
                    break;
                }
                n = m;
                if (i == 10)
                {
                    Console.WriteLine("Последовательность возрастает");
                }
            }
            Console.WriteLine("Задание 9\nВведите числa из последовательности");
            int count1 = 0, sum1 = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                count1++;
                if (count1 % 3 != 0)
                {
                    continue;
                }
                else { sum1 += n; }
            }
            while (n != 0);
            Console.WriteLine("Cумма равна " + sum1 +
                "\nЗадание 10\nВведите числа из последовательности");
            sum1 = 0;
        Vvod:
            n = Convert.ToInt32(Console.ReadLine());
            sum1 += n;
            if (n != 0)
            {
                goto Vvod;
            }
            Console.WriteLine("Cумма равна "+ sum1);
        } 
    }
}
