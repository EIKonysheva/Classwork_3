using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1\nВведите вещественное число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Модуль числа = " + Math.Sqrt(num * num));
            Console.WriteLine("1.2\nВведите два числа");
            num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(num * num) > Math.Sqrt(num1 * num1))
            { Console.WriteLine(num / 2); }
            else
            { Console.WriteLine("Абсолютное значение первого числа меньше или равно абсолютного значения второго числа"); }
            Console.WriteLine("1.3\nКакого животного встретила лягушка?");
            string animal = Console.ReadLine();
            animal=animal.ToLower();
            if (animal == "аллигатор" || animal == "alligator")
            { 
                Console.WriteLine("MouseSize = small"); 
            }
            else
            { 
                Console.WriteLine("MouthSize = wide");
            }
            Console.WriteLine("1.4\nКак зовут нашего посетителя?)");
            string name = Console.ReadLine();
            name = name.ToLower();
            try
            {
                switch (name)
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school aounseler":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politician":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("1.5\nВведите строку:");
            string str = "english";
            string str1 = Console.ReadLine();
            str1 = str1.ToLower();
            Console.WriteLine(str1.Contains(str));//true если есть, false ecли нет
           double sum = 1, x = 1;//Вычислить сумму 1 + 1/3 + 1/3^2 + ... + 1/3^8
            int i;
            for ( i = 1; i < 9; i++)
            {
                x *= 3;
                sum += 1 / x;
            }
            Console.WriteLine("\n2.1\nСумма равна: " + sum+
                "\n2.2");
            double wayhome = 0, distance = 0;
            int N = 100, k = 1;
            for (; k<N; k++)
            {
                if (k % 2 != 0)
                {
                    wayhome += (double)1 / k;
                }
                else
                    wayhome -= (double)1 / k;
                distance += (double)1 / k;
            }
            Console.WriteLine("Расстояние до дома "+ wayhome+"км\nПройденный путь "+distance+"км" +
                "\n2.3");
            Random rnd = new Random();
            double rainJan=0,rainM=0;
            
            for ( i=1; i< 32;i++)
            {
                rainJan += rnd.NextDouble()*100;
                rainM += rnd.NextDouble()*100;
            }
            Console.WriteLine("Среднедневное количество осадков за январь "+rainJan/31+"" +
                "\nСреднедневное количество осадков за март " + rainM / 31);
            Console.WriteLine("3.1");
            double chisl1 = 1, chisl2 = 2, znam1 = 1, znam2 = 1;
            while((Math.Abs(chisl2/znam2)-(chisl1/znam1))>0.001)
                {
                double chisl3 = chisl2, znam3 = znam2;
                chisl2 += chisl1; znam2 += znam1;
                chisl1 = chisl3; znam1 = znam3;
                }
            Console.WriteLine($"{chisl2}/{znam2}");
            Console.WriteLine("3.2\nВведите число n");
            N = Convert.ToInt32(Console.ReadLine());
            k = 1;
            while (k*k<=N)
            {
                k++;
            }
            Console.WriteLine(k*k);
            Console.WriteLine("3.3 a)");
             i = 100;
            while(i>=80)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("3.3 b)");
            i = 100;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i >= 80);
            Console.WriteLine("3.4");
            i = 5000;
            while (i % 39 != 0)
            {
                i--;
            }
            Console.WriteLine(i);
            Console.WriteLine("3.5 для пятерок");
            for (i = 1; i <= 5; i++)
            {
                for ( k = 1; k != i+1; k++)
                {
                    Console.Write("5 ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("3.5 для троек");
            for (k = 5; k > 0; k--)
            {
                for (i = k; i > 0; i--)
                {
                    Console.Write("3 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Дополнительное задание про шахматы" +
                "\nа)Ладья Введите координаты a,b от 1 до 8");
           int a = Convert.ToByte(Console.ReadLine());
            int b = Convert.ToByte(Console.ReadLine());
           Console.WriteLine("Введите координаты с,d от 1 до 8");
            int c = Convert.ToByte(Console.ReadLine());
            int d = Convert.ToByte(Console.ReadLine());
            if(a==c||b==d)
            { 
                Console.WriteLine("Ладья угрожает"); 
            }
            Console.WriteLine("Ладья не угрожает");
            Console.WriteLine("б)Слон Введите координаты с,d от 1 до 8");
             a = Convert.ToByte(Console.ReadLine());
             b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
             c = Convert.ToByte(Console.ReadLine());
             d = Convert.ToByte(Console.ReadLine());
            if (Math.Abs(a-c) == Math.Abs(d-b))
            {
                Console.WriteLine("Слон угрожает");
            }
            Console.WriteLine("Слон не угрожает");
            Console.WriteLine("в)Король Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if ((Math.Abs(a - c) <=1) || (Math.Abs(d - b)<=1))
            {
                Console.WriteLine("Король угрожает");
            }
            Console.WriteLine("Король не угрожает");
            Console.WriteLine("г)Ферзь Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if ((a == c || b == d)|| Math.Abs(a - c) == Math.Abs(d - b))
            {
                Console.WriteLine("Ферзь угрожает");
            }
            Console.WriteLine("Ферзь не угрожает");
            Console.WriteLine("г)Белая пешка Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if (b == 2 &&  b==4)
            {     
                Console.WriteLine("Белая пешка может попасть");               
            }
            else if ((d - b) ==1)
            {
                Console.WriteLine("Белая пешка может попасть");               
            }
            else if ((c - a) == 1 && (d - b) == 1 || (c - a) == 1 && (d - b) == -1)
            { 
                Console.WriteLine("Белая пешка может попасть"); 
            }
            else
                Console.WriteLine("Белая пешка не может попасть");
            Console.WriteLine("г)Белая пешка Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if (b == 2 && b == 4 && a == c)
            {
                Console.WriteLine("Белая пешка может попасть");
            }
            else if (a == c && (d - b) == 1)
            {
                Console.WriteLine("Белая пешка может попасть");
            }
            else if ((c - a) == 1 && (d - b) == 1 || (c - a) == -1 && (d - b) == 1)
            {
                Console.WriteLine("Белая пешка может попасть");
            }
            else
                Console.WriteLine("Белая пешка не может попасть");
            Console.WriteLine("г)Черная пешка Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if (b == 7 && b == 5 && a == c)
            {
                Console.WriteLine("Черная пешка может попасть");
            }
            else if (a == c && (d - b) == -1)
            {
                Console.WriteLine("Черная пешка может попасть");
            }
            else if ((c - a) == -1 && (d - b) == -1 || (c - a) == 1 && (d - b) == -1)
            {
                Console.WriteLine("Черная пешка может попасть");
            }
            else
                Console.WriteLine("Черная пешка не может попасть");
            Console.WriteLine("ж)Конь Введите координаты с,d от 1 до 8");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите координаты с,d от 1 до 8");
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());
            if ((Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2) || (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1)) 
            {
                Console.WriteLine("Конь угрожает");
            }
            else
             Console.WriteLine("Конь не угрожает"); 

        }
    }
}
