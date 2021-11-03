using System;

//На вход дается массив чисел. Необходимо найти 2 числа из массива, сумма которых будет давать заданное число.

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор чисел в массиве!");
            Console.WriteLine("Введите массив чисел через запятую.");
            string userInputNumbers = Console.ReadLine();
            Console.WriteLine("Введите целевое число, которое должно получиться из 2 чисел массива");
            int userInputResultNumber = Convert.ToInt32(Console.ReadLine());



            //Перевод введенного пользователем массива строк в массив чисел
            string[] taskNumbers = userInputNumbers.Split(',');
            int[] massiveNumbers = new int[taskNumbers.Length];
            for (int i = 0; i < taskNumbers.Length; i++)
            {
                massiveNumbers[i] = Convert.ToInt32(taskNumbers[i]);
            }

            //Простой перебор всего массива с выводом на экран вариантов сложения, если несколько. Во избежание дублирования вложенный цикл всегда "идет" вправо по массиву.
            for (int i = 0; i < massiveNumbers.Length; i++)
            {
                for (int j = i + 1; j < massiveNumbers.Length; j++)
                {
                    if (massiveNumbers[i] + massiveNumbers[j] == userInputResultNumber)
                    {
                        Console.WriteLine($"{massiveNumbers[i]} + {massiveNumbers[j]} = {userInputResultNumber}. Номера элементов {i} и {j}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
