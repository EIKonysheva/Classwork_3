using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1\nВведите число");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day > 0 && day <= 31)
            { Console.WriteLine(day + " Января"); }
            else
             if (day <= 59)
            { Console.WriteLine($"{day-31} февраля"); }
            else
            if (day <= 90)
            { Console.WriteLine($"{day - 59} марта"); }
            else
             if (day <= 120)
            { Console.WriteLine($"{day - 90} апреля"); }
            else
             if (day <= 151)
            { Console.WriteLine($"{day - 120} мая"); }
            else
             if (day <= 181)
            { Console.WriteLine($"{day - 151} июня"); }
            else
             if (day <= 212)
            { Console.WriteLine($"{day - 151} июля"); }
            else
              if (day <= 243)
            { Console.WriteLine($"{day - 212} августа"); }
            else
              if (day <= 273)
            { Console.WriteLine($"{day - 243} сентября"); }
            else
             if (day <= 304)
            { Console.WriteLine($"{day - 273} октября"); }
            else
             if (day <= 334)
            { Console.WriteLine($"{day - 304} ноября"); }
            else
             if (day <= 365)
            { Console.WriteLine($"{day - 334} декабря"); }
            else
             Console.WriteLine("Неверный ввод");
            Console.WriteLine("Задание 4.1\nВведите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            day = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                if (day > 0 && day <= 31)
                { Console.WriteLine(day + " Января " + year); }
                else
              if (day <= 60)
                { Console.WriteLine($"{day - 31} февраля " + year); }
                else
             if (day <= 91)
                { Console.WriteLine($"{day - 60} марта " + year); }
                else
              if (day <= 121)
                { Console.WriteLine($"{day - 91} апреля " + year); }
                else
              if (day <= 152)
                { Console.WriteLine($"{day - 121} мая " + year); }
                else
              if (day <= 182)
                { Console.WriteLine($"{day - 152} июня " + year); }
                else
              if (day <= 213)
                { Console.WriteLine($"{day - 152} июля " + year); }
                else
               if (day <= 244)
                { Console.WriteLine($"{day - 213} августа " + year); }
                else
               if (day <= 274)
                { Console.WriteLine($"{day - 244} сентября " + year); }
                else
              if (day <= 305)
                { Console.WriteLine($"{day - 274} октября " + year); }
                else
              if (day <= 335)
                { Console.WriteLine($"{day - 305} ноября " + year); }
                else
              if (day <= 366)
                { Console.WriteLine($"{day - 335} декабря " + year); }
            }
            else
            {
                if (day > 0 && day <= 31)
                { Console.WriteLine(day + " Января " + year); }
                else
              if (day <= 59)
                { Console.WriteLine($"{day - 31} февраля " + year); }
                else
             if (day <= 90)
                { Console.WriteLine($"{day - 59} марта " + year); }
                else
              if (day <= 120)
                { Console.WriteLine($"{day - 90} апреля " + year); }
                else
              if (day <= 151)
                { Console.WriteLine($"{day - 120} мая " + year); }
                else
              if (day <= 181)
                { Console.WriteLine($"{day - 151} июня " + year); }
                else
              if (day <= 212)
                { Console.WriteLine($"{day - 151} июля " + year); }
                else
               if (day <= 243)
                { Console.WriteLine($"{day - 212} августа " + year); }
                else
               if (day <= 273)
                { Console.WriteLine($"{day - 243} сентября " + year); }
                else
              if (day <= 304)
                { Console.WriteLine($"{day - 273} октября " + year); }
                else
              if (day <= 334)
                { Console.WriteLine($"{day - 304} ноября " + year); }
                else
              if (day <= 365)
                { Console.WriteLine($"{day - 334} декабря " + year); }
                else
                    Console.WriteLine("Неверный ввод");
            }
        }
    }
}
