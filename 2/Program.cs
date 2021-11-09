using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; // переменные 
            x = 0; // присваиваем значение

            while (x <= 2 * Math.PI)
            { 
               y = Math.Round(Math.Tan(x), 1); // вычисляем 
               Console.WriteLine($"x = {Math.Round(x, 2)} y = {y}"); // вывод

               x += Math.PI / 12; // шаг 
            }

            Console.ReadLine(); // задерживаем консоль
        }
    }
}
