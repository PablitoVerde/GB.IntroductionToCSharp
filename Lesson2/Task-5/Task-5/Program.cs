using System;

/*
 * (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести
сообщение «Дождливая зима».
*/

namespace Task_5
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

    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие
            Console.WriteLine("Добро пожаловать в программу!");

            // Инициализация переменных для цикла
            int faultsCounter = 0; //счетчик ошибок на неверное указание номера
            bool resultBool = true; //флаг на решение задачи
            Months m;
            m = Months.January; // перечисление месяцев


            while (faultsCounter < 3 && resultBool)
            {

                // Получение пользовательских данных
                Console.Write("Ввелите порядковый номер месяца: ");
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введи минимальную температуру в градусах Цельсия: ");
                int minTemperature = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введи максимальную температуру в градусах Цельсия: ");
                int maxTemperature = Convert.ToInt32(Console.ReadLine());

                double meanTemperature = ((double)minTemperature + (double)maxTemperature) / 2;

                // проверка на правильность указания номера
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    m = (Months)monthNumber; // приведение числа int к перечислению

                    //проверка на "дождливость"
                    if ((monthNumber == 12 || monthNumber <= 2) && meanTemperature > 0)
                    {
                        Console.WriteLine($"Дождливая зима");
                    }
                    else
                    {
                        Console.WriteLine($"Текущий месяц - {Convert.ToString(m)}. Среднесуточная температура в градусах составляет: {meanTemperature}.");
                    }
                    resultBool = false;
                }
                else
                {
                    faultsCounter++;
                    Console.WriteLine($"Неверно указан порядковый номер месяца. Попыток осталось {3 - faultsCounter}.");
                }

            }

            // Ожидание
            Console.ReadKey();
        }
    }
}
