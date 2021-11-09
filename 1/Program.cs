using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные 
            x = -2; // присваиваем значение

            while(x <= 4)
            {
                if (x == 0.5 || x == 1) // проверяем на наличие решений
                {
                    Console.WriteLine("Решений нет");
                    // return;
                }
                else
                {
                    y = Math.Sqrt(x / (x - 1)); // вычисляем 
                    Console.WriteLine($"x = {x} y = {y:0.00}"); // вывод
                }
                x += 0.5;
            }

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
