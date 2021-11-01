using System;

namespace Task_2
{
    class Program
    {
        //Необходимо проинициализировать первый элемент перечисления, поскольку это автоматически проинициализирует последующией элементы
        // Так, февраль - 2, март - 3, ..., декабрь - 12
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        static void Main(string[] args)
        {
 
            // Приветствие
            Console.WriteLine("Добро пожаловать в программу определения месяца по его порядковому номеру!");

            // Инициализация переменных для цикла
            int faultsCounter = 0; //счетчик ошибок на неверное указание номера
            bool resultBool = true; //флаг на решение задачи
            Months m;
            m = Months.January; // перечисление месяцев

            
            while (faultsCounter < 3 && resultBool)
            {
                Console.Write("Ввелите число от 1 до 12: ");
                int monthNumber = Convert.ToInt32(Console.ReadLine());

                // проверка на правильность указания номера
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    m = (Months) monthNumber; // приведение числа int к перечислению
                    Console.WriteLine($"Текущий месяц - {Convert.ToString(m)}.");
                    resultBool = false;
                }
                else
                {
                    faultsCounter++;
                    Console.WriteLine($"Неверно указан порядковый номер месяца. Попыток осталось {3 - faultsCounter}.");
                }

            }

            Console.ReadKey();
        }
    }
}
