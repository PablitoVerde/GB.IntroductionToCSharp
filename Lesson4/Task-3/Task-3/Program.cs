using System;
/*
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер
месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
Autumn. Написать метод, принимающий на вход значение из этого перечисления и
возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
ввести с клавиатуры номер месяца и вывести название времени года. Если введено
некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
*/

namespace Task_3
{
    class Program
    {
        enum season
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.Write("Введите порядковый номер месяца: ");
            string monthNumber = Console.ReadLine();

            bool userNumberCheck = true;

            while (userNumberCheck)
            {
                int n;

                if (int.TryParse(monthNumber, out n))
                {
                    if (n <= 12 && n >= 1)
                    {

                        string season = GetSeasonEnum(n);
                        Console.WriteLine(GetSeasonValue(season));
                        userNumberCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 12.");
                        Console.WriteLine("Введите порядковый номер заново: ");
                        monthNumber = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                    Console.WriteLine("Введите порядковый номер заново: ");
                    monthNumber = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }

        //Метод, определяющий по числу месяца сезон года из перечисления enum.
        static string GetSeasonEnum(int _monthNumber)
        {
            string result = "";
            if (_monthNumber > 12 || _monthNumber < 1)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12.");
            }
            else if (_monthNumber <= 2 || _monthNumber == 12)
            {
                result = season.Winter.ToString();
            }
            else if (_monthNumber >= 3 && _monthNumber <= 5)
            {
                result = season.Spring.ToString();
            }
            else if (_monthNumber >= 6 && _monthNumber <= 8)
            {
                result = season.Summer.ToString();
            }
            else if (_monthNumber >= 9 && _monthNumber <= 11)
            {
                result = season.Autumn.ToString();
            }
            return result;

        }

        //Метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень)
        static string GetSeasonValue(string _season)
        {
            string result = "";

            switch (_season)
            {
                case "Winter":
                    result = "Зима";
                    break;
                case "Spring":
                    result = "Весна";
                    break;
                case "Summer":
                    result = "Лето";
                    break;
                case "Autumn":
                    result = "Осень";
                    break;
            }
            return result;

        }
    }
}
