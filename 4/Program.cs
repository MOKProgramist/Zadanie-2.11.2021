using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, max; // переменные
            x = -2; //  начальное значение
            max = 0;

            while (x <= 2) // пока x < 2 цикл работает 
            {
                y = -1 * Math.Pow(x, 2) + 3 * x + 1.15; // функция
                max = max < y ? y : max; // тернарная операция 
                Console.WriteLine($"x = {x:0.0} y = {y:0.00}");
                x += 0.1; // шаг
            }
            Console.WriteLine("max = {0}", max);
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
