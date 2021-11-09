using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, min; // переменные
            x = -1; //  начальное значение
            min = 0; 

            while(x <= 3) // пока x > 3 цикл работает 
            {
                if (x == 0)
                {
                    Console.WriteLine("Решений нет"); // на ноль делить нельзя     
                }
                else
                {
                    y = x + (1 / x); // функция
                    min = min > y ? y : min; // тернарная операция 
                    Console.WriteLine($"x = {x} y = {y:0.00}");
                }
                x += 0.5; // шаг
            }
            Console.WriteLine("min = {0}", min); 
            Console.ReadLine(); // задерживаем консоль
        }
    }
}
