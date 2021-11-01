using System;


/*
 * 6. (*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру
расписания недели, к примеру, чтобы описать работу какого либо офиса. Явный пример -
офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до
воскресенья и выведите его на экран консоли.
*/

namespace Task_6
{
    class Program
    {
        [Flags]
        //перечисление. Элементам присваиваем флаги дней недели
        public enum weekDays : byte
        {
            Monday = 0b_0000_0001,
            Tuesday = 0b_0000_0010,
            Wednesday = 0b_0000_0100,
            Thursday = 0b_0000_1000,
            Friday = 0b_0001_0000,
            Saturday = 0b_0010_0000,
            Sunday = 0b_0100_0000
        }


        static void Main(string[] args)
        {

            //Первый офис работает вторник, среду, четверг, пятницу
            var office1Mask = weekDays.Tuesday | weekDays.Wednesday | weekDays.Thursday | weekDays.Friday;

            //Второй офис - все 7 дней в неделю
            var office2Mask = weekDays.Monday | weekDays.Tuesday | weekDays.Wednesday | weekDays.Thursday | weekDays.Friday | weekDays.Saturday | weekDays.Sunday;

            Console.WriteLine($"Работа в понедельник, офис№1 - {(office1Mask & weekDays.Monday) != 0}, офис№2 - {(office2Mask & weekDays.Monday) != 0}.");
            Console.WriteLine($"Работа во вторник, офис№1 - {(office1Mask & weekDays.Tuesday) != 0}, офис№2 - {(office2Mask & weekDays.Tuesday) != 0}.");
            Console.WriteLine($"Работа в среду, офис№1 - {(office1Mask & weekDays.Wednesday) != 0}, офис№2 - {(office2Mask & weekDays.Wednesday) != 0}.");
            Console.WriteLine($"Работа в четверг, офис№1 - {(office1Mask & weekDays.Thursday) != 0}, офис№2 - {(office2Mask & weekDays.Thursday) != 0}.");
            Console.WriteLine($"Работа в пятницу, офис№1 - {(office1Mask & weekDays.Friday) != 0}, офис№2 - {(office2Mask & weekDays.Friday) != 0}.");
            Console.WriteLine($"Работа в субботу, офис№1 - {(office1Mask & weekDays.Saturday) != 0}, офис№2 - {(office2Mask & weekDays.Saturday) != 0}.");
            Console.WriteLine($"Работа в воскресенье, офис№1 - {(office1Mask & weekDays.Sunday) != 0}, офис№2 - {(office2Mask & weekDays.Sunday) != 0}.");

            Console.ReadKey();
        }
    }
}
