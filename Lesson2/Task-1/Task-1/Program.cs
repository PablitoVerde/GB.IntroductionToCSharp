using System;

/*
 * Запросить у пользователя минимальную и максимальную температуру за сутки и вывести
среднесуточную температуру.
 * 
 * 
 * */

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Приветствие
            Console.WriteLine($"Привет! Давай узнаем среднесуточную температуру за {DateTime.Now.ToShortDateString()}!");


            // Получение пользовательских данных
            Console.Write("Введи минимальную температуру в градусах Цельсия: ");
            int minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи максимальную температуру в градусах Цельсия: ");
            int maxTemperature = Convert.ToInt32(Console.ReadLine());


            // Вычисление среднесуточной температуры. Необходимо приведение к double, поскольку среднесуточная температура в рамках задания может быть с одним знаком после запятой
            double meanTemperature = ((double)minTemperature + (double)maxTemperature) / 2;
              
            
            // Вывод результата в консоль
            Console.WriteLine($"Среднесуточная температура составляет: {meanTemperature}");


            // Ожидание
            Console.ReadKey();
        }
    }
}
