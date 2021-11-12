using System;

/*
 * Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
результат на экран.
*/

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Привет!");
            Console.Write("Введите набор чисел через пробел: ");

            string stringMass = Console.ReadLine();

            //С использованием функционала библиотеки
            Console.WriteLine($"Сумма всех введенных чисел равна: {GetIntSum(stringMass)}.");

            //Свой метод
            Console.WriteLine($"Сумма всех введенных чисел равна: {GetIntSumOwnFunction(stringMass)}.");

            Console.ReadKey();
        }


        //Метод принимает строку, разбивает ее на массив по символу "пробел", цикл подсчитывает сумму
        static int GetIntSum(string _stringMass)
        {
            string[] stringMassDivided = _stringMass.Split(" ");

            int sum = 0;
            for (int i = 0; i < stringMassDivided.Length; i++)
            {
                sum += Convert.ToInt32(stringMassDivided[i]);
            }

            return sum;
        }

        static int GetIntSumOwnFunction(string _stringMass)
        {

            //Блок для подсчета количества чисел в строке. При правильном вводе между 3 числами будет 2 пробела.
            int numbersCount = 1;
            char[] charsArray = _stringMass.ToCharArray();

            for (int i = 0; i < charsArray.Length; i++)
            {
                if (charsArray[i] == ' ')
                    numbersCount++;
            }

            //создание массива строк с числами
            string[] numbers = new string[numbersCount];

            //разделение массива строк на числа
            int n = 0;
            for (int i = 0; i < charsArray.Length; i++)
            {
                if (charsArray[i] != ' ')
                {
                    numbers[n] += charsArray[i];
                }
                else
                {
                    n++;
                }
            }

            //подсчет суммы
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i]);
            }

            return sum;
        }

    }
}
