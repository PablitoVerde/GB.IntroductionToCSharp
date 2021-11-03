using System;

/*
 * Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
список телефонных контактов: первый элемент хранит имя контакта, второй — номер
телефона/e-mail.
 */

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Размеры телефонной книги
            int amountParameter = 5;
            int dataParameter = 2;

            string[,] telephoneBook = new string[amountParameter, dataParameter];

            //Приветствие
            Console.WriteLine("Добро пожаловать в телефонный справочник");
            Console.WriteLine("Заполните карточки");

            //Заполнение массива пользовательскими данными
            for (int i = 0; i < amountParameter; i++)
            {
                Console.Write("Введите имя: ");
                telephoneBook[i, 0] = Console.ReadLine();
                Console.Write("Введите номер телефона или e-mail: ");
                telephoneBook[i, 1] = Console.ReadLine();

                Console.WriteLine($"Введено контактов: {i + 1}. Осталось памяти: {amountParameter - 1 - i}");
            }

            //Вывод всего массива на экран
            for(int i = 0; i<amountParameter;i++)
            {
                Console.WriteLine($"Имя: {telephoneBook[i,0]}. Контактные данные: {telephoneBook[i,1]}");
            }

            Console.ReadKey();

        }
    }
}
