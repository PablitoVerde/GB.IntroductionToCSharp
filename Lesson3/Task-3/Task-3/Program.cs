using System;


//Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приветствие
            Console.WriteLine("Привет! Это программа для вывода текста в консоль наоборот.");
            Console.WriteLine("Введите текст.");

            //Получение пользовательских данных
            string userText = Console.ReadLine();

            //Инициализация массива символов из пользовательского текста
            char[] textArray = userText.ToCharArray();

            //Инициализация нового массива под измененный текст
            char[] textArrayReverted = new char[textArray.Length];

            //перебор символов из массива и присвоение значений новому массиву
            for (int i = 0; i < textArrayReverted.Length; i++)
            {
                textArrayReverted[i] = textArray[textArray.Length - 1 - i];
                Console.Write(textArrayReverted[i]);
            }

            Console.Read();
        }
    }
}
