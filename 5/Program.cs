using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n; // переменные
            n = 0;  x = 1; // начальное значение
            
            while(x <= 100)
            {
                if(x % 3 == 0) // кратность числа на 3
                {
                    n += Math.Pow(x, 2); // квадрат числа 
                }
                x++; // шаг +1
            }

            Console.WriteLine($"Сумма квадратов\nвсех натуральных чисел\nкратных 3 = {n}");
            Console.ReadLine(); //задерживаем консоль
        }
    }
}
