using System;


/*
 * Написать метод GetFullName(string firstName, string lastName, string
patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
3–4 разных ФИО.
*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приветствие и получение пользовательских данных
            Console.WriteLine("Привет!");
            Console.Write("Сколько пользователей будем выводить? ");
            int count = Convert.ToInt32(Console.ReadLine());

            //цикл на перечисление всех людей
            for (int i = 0; i < count; i++)
            {
                (string personLastname, string personFirstname, string personPatronymic) = GetUserData();
                PrintFullName(GetFullName(personLastname, personFirstname, personPatronymic));
            }   

            Console.ReadKey();
        }

        //метод получения от пользователя ФИО в разных переменных
        static (string, string, string) GetUserData()
        {
            Console.Write("Введите фамилию: ");
            string _lastname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string _firstname = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string _patronymic = Console.ReadLine();

            return (_lastname, _firstname, _patronymic);
        }

        //метод создания одной строки с ФИО
        static string GetFullName(string lastname, string firstName, string patronymic)
        {
            return ($"{lastname} {firstName} {patronymic}.");
        }

        //метод вывода на экран ФИО
        static void PrintFullName(string fullName)
        {
            Console.WriteLine(fullName);
        }
    }
}
